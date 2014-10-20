using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Memory
{
    public partial class Memory : Form
    {
        private List<HumanPlayer> playerList;
        private Image[] selectedDeckArray;
        private int selectedDeck;
        private int rows;
        private int columns;
        private List<Card> allCardsInPlayList;
        private List<Card> compareTwoCardsList;
        private Timer myTimer;
        private Timer myTimer2;
        private Timer imageTimer;
        private Timer imageTimer2;
        private Stream[] sounds = { Properties.Resources.pair_FX, Properties.Resources.All_hail_the_winner, Properties.Resources.Tie };
        private int time;
        private int totalCardSize;
        private int cardSize;
        private int space;
        private Image[] timerImages;
        private Image[] timerImages2;
        int timerCounter;
        int timerCounter2;
        int time2;

        public Memory(List<HumanPlayer> _playerList, int _columns, int _rows, int _selectedDeck, int _time, int _time2) //constructor
        {
            InitializeComponent();

            this.playerList = _playerList;
            this.columns = _columns;
            this.rows = _rows;
            this.selectedDeck = _selectedDeck;
            this.time = _time;
            this.time2 = _time2;

            allCardsInPlayList = new List<Card>();
            compareTwoCardsList = new List<Card>();
           
            myTimer = new Timer();
            myTimer.Interval = time;
            myTimer.Tick += new System.EventHandler(TimerEvent);

            myTimer2 = new Timer();
            myTimer2.Interval = time2;
            myTimer2.Tick += new System.EventHandler(TimerEvent2);

            timerImages = Images.Timer();
            imageTimer = new Timer();
            imageTimer.Interval = time / timerImages.Count();
            imageTimer.Tick += imageTimer_Tick;
            timerCounter = 0;

            timerImages2 = Images.Timer();
            imageTimer2 = new Timer();
            imageTimer2.Interval = time2 / timerImages2.Count();
            imageTimer2.Tick += imageTimer_Tick2;
            timerCounter2 = 0;

            //add playerlist to listbox and create datasource
            lblPlayersInGame.Text = "";
            foreach (HumanPlayer p in playerList)
            {
                lblPlayersInGame.Text += p.Name + "\nScore: " + p.Points + "\nWins: " + p.Winnings + "\n\n";
            }

            if (selectedDeck == 1)
            {
                selectedDeckArray = Images.DeckAnimals();
            }
            else
            {
                selectedDeckArray = Images.DeckOther();
            }

            //calculate size of cards
            totalCardSize = pCards.Width / columns;
            space = totalCardSize / 6;
            cardSize = totalCardSize - space;

            //add all cards to board
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Card c = new Card(j, i, HandleEventClick, cardSize, space);
                    allCardsInPlayList.Add(c);
                    this.pCards.Controls.Add(c);
                }
            }

            RandomizeIsInCardList(rows * columns, allCardsInPlayList, selectedDeckArray); //call method to ranomize cards and give id to cards and pictures

            //selects first player in listbox to begin game

            playerList[0].CurrentlyPlaying = true;
            lblPlayerTurn.Text = playerList[0].Name + "'s turn";
        }

       

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            if (timerCounter < timerImages.Count())
            {
                pbTimer.Image = timerImages[timerCounter];
                timerCounter++;
            }
            else
            {
                imageTimer.Stop();
                timerCounter = 0;
                pbTimer.Image = timerImages[timerImages.Count() - 1];
            }
        }

        private void imageTimer_Tick2(object sender, EventArgs e)
        {
            if (timerCounter2 < timerImages2.Count())
            {
                pbTimer.Image = timerImages2[timerCounter2];
                timerCounter2++;

            }
            else
            {
                imageTimer2.Stop();
                timerCounter2 = 0;
                pbTimer.Image = timerImages2[timerImages2.Count() - 1];
            }
        }


        public void HandleEventClick(object sender, EventArgs e) //This is the method for the EventHandler that handles all clicks on cards
        {
            Card c = sender as Card;
            c.Image = c.Front;
            c.Flipped = true;
            compareTwoCardsList.Add(c);
            c.Enabled = false;

            if (compareTwoCardsList.Count == 1)
            {
                myTimer.Start();
                imageTimer.Start();
            }
            else if (compareTwoCardsList.Count == 2)
            {

                myTimer.Stop();
                imageTimer.Stop();
                timerCounter = 0;
                pbTimer.Image = timerImages[timerImages.Count() - 1];
                CompareCards();
            }
        }


        public void TimerEvent(object sender, EventArgs e)
        {
            foreach (Card c in compareTwoCardsList)
            {
                c.Flipped = false;
                c.Enabled = true;
            }

            if (compareTwoCardsList.Count == 1)
            {
                compareTwoCardsList[0].Image = compareTwoCardsList[0].Back;
                compareTwoCardsList.Clear();
            }
            else
            {
                compareTwoCardsList[0].Image = compareTwoCardsList[0].Back;
                compareTwoCardsList[1].Image = compareTwoCardsList[1].Back;
                compareTwoCardsList.Clear();
            }

            foreach (Card c in allCardsInPlayList)
            {
                if (c.Flipped == false)
                {
                    c.Enabled = true;
                }
            }
            GoToNextPlayer();
        }

        public void TimerEvent2(object sender, EventArgs e)
        {
            myTimer.Stop();
            imageTimer.Stop();
            timerCounter = 0;
            pbTimer.Image = timerImages2[timerImages2.Count() - 1];

            foreach (Card c in compareTwoCardsList)
            {
                c.Flipped = false;
                c.Enabled = true;
            }

            if (compareTwoCardsList.Count == 1)
            {
                compareTwoCardsList[0].Image = compareTwoCardsList[0].Back;
                compareTwoCardsList.Clear();
            }
            else
            {
                compareTwoCardsList[0].Image = compareTwoCardsList[0].Back;
                compareTwoCardsList[1].Image = compareTwoCardsList[1].Back;
                compareTwoCardsList.Clear();
            }

            foreach (Card c in allCardsInPlayList)
            {
                if (c.Flipped == false)
                {
                    c.Enabled = true;
                }
            }
            GoToNextPlayer();
        }

        public void CompareCards()
        {
            if (compareTwoCardsList[0].Id == (compareTwoCardsList[1].Id))
            {

                myTimer2.Stop();
                imageTimer2.Stop();
                timerCounter2 = 0;
                pbTimer.Image = timerImages2[timerImages2.Count() - 1];
                GivePoint();
                compareTwoCardsList[0].Enabled = false;
                compareTwoCardsList[1].Enabled = false;
                IsThereAWinner();
                compareTwoCardsList.Clear();
            }
            else
            {
                foreach (Card c in allCardsInPlayList) //no cards are clickable during timer interval
                {
                    c.Enabled = false;
                }
                myTimer2.Start();
                imageTimer2.Start();
            }
        }

        public void GoToNextPlayer()
        {
            int i;
            foreach (HumanPlayer p in playerList)
            {
                if (p.CurrentlyPlaying == true)
                {
                    i = playerList.IndexOf(p);
                    p.CurrentlyPlaying = false;

                    if (i == (playerList.Count - 1)) //if last in list, jump to first player
                    {
                        i = 0;
                    }
                    else
                    {
                        i += 1;
                    }
                    playerList[i].CurrentlyPlaying = true;
                    lblPlayerTurn.Text = playerList[i].Name + "'s turn";
                    break;
                }
            }
            myTimer.Stop();
            myTimer2.Stop();
            imageTimer.Stop();
            imageTimer2.Stop();
            timerCounter = 0;
            timerCounter2 = 0;
            pbTimer.Image = timerImages[timerImages.Count() - 1];
            pbTimer.Image = timerImages2[timerImages2.Count() - 1];
           
        }

        public void GivePoint()
        {
            foreach (HumanPlayer p in playerList)
            {
                if (p.CurrentlyPlaying == true)
                {
                    p.Points += 1;
                    SoundPlayer player0 = new SoundPlayer(sounds[0]);
                    player0.Play();
                    player0.Stream.Position = 0;
                }
            }

            lblPlayersInGame.Text = "";
            foreach (HumanPlayer p in playerList)
            {
                lblPlayersInGame.Text += p.Name + "\nScore: " + p.Points + "\nWins: " + p.Winnings + "\n\n";
            }
        }

        private void IsThereAWinner()
        {
            int totalPointsAllPlayers = 0;
            int highestPoint = 0;
            List<HumanPlayer> winnerList = new List<HumanPlayer>();

            foreach (HumanPlayer p in playerList)
            {
                totalPointsAllPlayers += p.Points;
            }

            if (totalPointsAllPlayers == allCardsInPlayList.Count / 2) //then we have winner/winners
            {
                for (int i = 0; i < playerList.Count; i++)
                {
                    if (playerList[i].Points >= highestPoint)
                    {
                        highestPoint = playerList[i].Points;
                    }
                }
                foreach (HumanPlayer p in playerList)
                {
                    if (p.Points == highestPoint)
                    {
                        winnerList.Add(p);
                        p.Winnings += 1;
                    }
                    p.CurrentlyPlaying = false;
                }
                if (winnerList.Count > 1)
                {
                    SoundPlayer player1 = new SoundPlayer(sounds[2]);
                    player1.Play();
                    player1.Stream.Position = 0;
                }
                else
                {
                    SoundPlayer player1 = new SoundPlayer(sounds[1]);
                    player1.Play();
                    player1.Stream.Position = 0;
                }
                foreach (HumanPlayer p in playerList)
                {
                    p.Points = 0;
                }

                EndScreen endScreen = new EndScreen(winnerList, playerList, columns, rows, selectedDeck, time, time2);
                this.Dispose();
                endScreen.ShowDialog();
                winnerList.Clear();
            }
             

        }

        private void RandomizeIsInCardList(int numberOfCards, List<Card> listofCards, Image[] deckOfCards)
        {
            List<int> shuffledIntList = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < numberOfCards / 2; i++) //makes a ranomized list to pair the id of the card with.
            {
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
                shuffledIntList.Insert(rand.Next(0, shuffledIntList.Count + 1), i);
            }

            for (int i = 0; i < listofCards.Count; i++)
            {
                listofCards[i].Id = shuffledIntList[i];
                listofCards[i].Front = deckOfCards[shuffledIntList[i]];
                listofCards[i].Image = deckOfCards[deckOfCards.Length - 1];
                listofCards[i].Back = deckOfCards[deckOfCards.Length - 1];//always the last card in deck
            }
        }

 

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}



