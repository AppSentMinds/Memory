using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class EndScreen : Form
    {
        private List<HumanPlayer> winnerList;
        string resultTied = "";
        string message = "";
        private int rows;
        private int columns;
        private int selectedDeck;
        private int time;
        private List<HumanPlayer> playerList;
        private int time2;

        public EndScreen(List<HumanPlayer> _winnerList, List <HumanPlayer> _playerList, int _columns, int _rows, int _selectedDeck, int _time, int _time2)
        {
            InitializeComponent();
            this.winnerList = _winnerList;
            this.playerList = _playerList;
            this.columns = _columns;
            this.rows = _rows;
            this.selectedDeck = _selectedDeck;
            this.time = _time;
            this.time2 = _time2;

            if (winnerList.Count == 1)
            {
                lblWinnerText.Text = "The winner is:\n" + winnerList[0].Name + "!";
            }
            else
            {
                foreach (HumanPlayer winner in winnerList)
                {
                    resultTied += "\n" + winner.Name;
                }
                lblWinnerText.Text = "It was a tie between: " + resultTied;
            }

        
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            this.Dispose();
            formStart.ShowDialog();
        }

        private void btnRematch_Click(object sender, EventArgs e)
        {
            Memory memory = new Memory(playerList, columns, rows, selectedDeck, time, time2);
            this.Dispose();
            memory.ShowDialog();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
