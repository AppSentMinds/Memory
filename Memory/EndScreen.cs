﻿using System;
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
        private List<Player> winnerList;
        string resultTied = "";
        private int rows;
        private int columns;
        private int selectedDeck;
        private int time;
        private List<Player> playerList;
        private int time2;
        private int difficulty;

        public EndScreen(List<Player> _winnerList, List <Player> _playerList, int _columns, int _rows, int _selectedDeck, int _time, int _time2, int _difficulty)
        {
            InitializeComponent();
            this.winnerList = _winnerList;
            this.playerList = _playerList;
            this.columns = _columns;
            this.rows = _rows;
            this.selectedDeck = _selectedDeck;
            this.time = _time;
            this.time2 = _time2;
            this.difficulty = _difficulty;

            if (winnerList.Count == 1)
            {
                lblWinnerText.Text = "The winner is:\n" + winnerList[0].Name + "!";
            }
            else
            {
                foreach (Player winner in winnerList)
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
            Memory memory = new Memory(playerList, columns, rows, selectedDeck, time, time2, difficulty);
            this.Dispose();
            memory.ShowDialog();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
