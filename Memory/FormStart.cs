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
    public partial class FormStart : Form
    {
        string name;
        List<Player> playerList = new List<Player>();
        private Stream[] sounds = { Properties.Resources.welcome, Properties.Resources.Start_playing };
        int selectedDeck; //1 = animals 2 = mixed things
        int columns;
        int rows;
        int choice;
        int time;
        int time2;

        public FormStart()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            lblInfo.Text = "";

            gbNames.Visible = true;
            gbDecks.Visible = false;
            gbSize.Visible = false;
            btnNextNames.Enabled = false;
            pbDecksArrow.Visible = false;
            pbSizeArrow.Visible = false;
            lblDecksInfo.Visible = false;
            lblSizeInfo.Visible = false;
            btnNextDecks.Enabled = false;
            tbName.MaxLength = 18;

            cbCards.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCards.Items.Add("4 cards - very easy");
            cbCards.Items.Add("16 cards - easy");
            cbCards.Items.Add("36 cards - medium");
            cbCards.Items.Add("64 cards - hard");

            cbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTime.Items.Add("Slow");
            cbTime.Items.Add("Medium");
            cbTime.Items.Add("Fast");
            
            SoundPlayer player0 = new SoundPlayer(sounds[0]);
            player0.Play();
            player0.Stream.Position = 0;

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                playerList.RemoveAt(lbNames.SelectedIndex);
                lbNames.Items.Remove(lbNames.SelectedItem);
                lblInfo.Text = "";

                //check if listbox has 2 items to make startbutton enabled or disabled
                if (lbNames.Items.Count > 5)
                {
                    btnStart.Enabled = false;
                    btnNextNames.Enabled = false;
                    lblInfo.Text = "Maximum 5 players.\nRemove additional\nplayers";
                }
                else if (lbNames.Items.Count < 2)
                {
                    btnStart.Enabled = false;
                    btnNextNames.Enabled = false;
                    lblInfo.Text = "Need at least 2 players.";
                }
                else
                {
                    btnNextNames.Enabled = true;
                }
                

            }
            catch
            {
                lblInfo.Text = "Nothing selected!";
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AddPlayer();
            }
        }

        private void btnNextNames_Click(object sender, EventArgs e)
        {
            gbNames.Visible = false;
            gbDecks.Visible = true;
            pbNamesArrow.Visible = false;
            lblNamesInfo.Visible = false;
            pbDecksArrow.Visible = true;
            lblDecksInfo.Visible = true;
        }

        private void btnBackCards_Click(object sender, EventArgs e)
        {
            gbDecks.Visible = false;
            gbNames.Visible = true;
            pbNamesArrow.Visible = true;
            lblNamesInfo.Visible = true;
            pbDecksArrow.Visible = false;
            lblDecksInfo.Visible = false;
        }

        private void pbDeckAnimals_Click(object sender, EventArgs e)
        {
            pbDeckAnimals.BackgroundImage = Properties.Resources.BackcardGreen;
            pbDeckMixed.BackgroundImage = null;
            pbDeckMixed.BackColor = Color.Transparent;
            selectedDeck = 1;
            btnNextDecks.Enabled = true;
        }

        private void pbDeckMixed_Click(object sender, EventArgs e)
        {
            pbDeckAnimals.BackgroundImage = null;
            pbDeckMixed.BackgroundImage = Properties.Resources.BackcardRed;
            pbDeckAnimals.BackColor = Color.Transparent;
            selectedDeck = 2;
            btnNextDecks.Enabled = true;
        }

        private void btnNextDecks_Click(object sender, EventArgs e)
        {
            gbDecks.Visible = false;
            gbSize.Visible = true;
            pbSizeArrow.Visible = true;
            lblSizeInfo.Visible = true;
            pbDecksArrow.Visible = false;
            lblDecksInfo.Visible = false;
        }

        private void btnBackSize_Click(object sender, EventArgs e)
        {
            gbSize.Visible = false;
            gbDecks.Visible = true;
            pbDecksArrow.Visible = true;
            lblDecksInfo.Visible = true;
            pbSizeArrow.Visible = false;
            lblSizeInfo.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SoundPlayer player0 = new SoundPlayer(sounds[1]);
            player0.Play();
            player0.Stream.Position = 0;

            Memory memory = new Memory(playerList, columns, rows, selectedDeck, time, time2);
            this.Hide();
            memory.ShowDialog();
           
        }

        private void cbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = cbCards.SelectedIndex;
            switch (choice)
            {
                case 0:
                    columns = 2;
                    rows = 2;
                    checkInput();
                    break;
                case 1:
                    columns = 4;
                    rows = 4;
                    checkInput();
                    break;
                case 2:
                    columns = 6;
                    rows = 6;
                    checkInput();
                    break;
                case 3:
                    columns = 8;
                    rows = 8;
                    checkInput();
                    break;
            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = cbTime.SelectedIndex;
            switch (choice)
            {
                case 0:
                    time = 5000;
                    time2 = 1500;
                    checkInput();
                    break;
                case 1:
                    time = 3000;
                    time2 = 1000;
                    checkInput();
                    break;
                case 2:
                    time = 1000;
                    time2 = 500;
                    checkInput();
                    break;
            }
        }

        //METHODS BELOW THIS POINT

        private void AddPlayer()
        {
            if (tbName.Text != "")
            {
                lblInfo.Text = "";
                name = tbName.Text;
                Player p = new humanPlayer(name);
                playerList.Add(p);
                lbNames.Items.Add(p.Name);
                tbName.Clear();
               
                if (lbNames.Items.Count > 5)
                {
                    btnStart.Enabled = false;
                    btnNextNames.Enabled = false;
                    lblInfo.Text = "Maximum 5 players.\nRemove additional\nplayers";
                }
                else if (lbNames.Items.Count < 2)
                {
                    btnStart.Enabled = false;
                    btnNextNames.Enabled = false;
                    lblInfo.Text = "Need at least 2 players.";
                } 
                else
                {
                    btnNextNames.Enabled = true;
                }
            }
            else
            {
                lblInfo.Text = "No input, try again.";
            }
        }

        private void checkInput()
        {
            if (columns != 0 && time != 0)
            {
                btnStart.Enabled = true;
            }

        }
    }
}

