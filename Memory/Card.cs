using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Memory
{
    public delegate void myEventHandler(object sender, EventArgs e); //ny delegate som skapar en pekare på en metod

    public class Card : PictureBox //FRÅGA ANTON: PUBLIC, MÅSTE DET VARA SÅ?????
    {
        private Image front; //side down, will vary
        private Image back; //side up, always the same
        private int id;
        private bool flipped = false;
        private int startX;
        private int startY;

        public Card(int posX, int posY, myEventHandler HandleEventClick, int cardSize, int space)
        {
            startX = space / 2;
            startY = space / 2;
            Location = new System.Drawing.Point(startX + posX * (cardSize + space), startY + posY * (cardSize + space));
            Size = new System.Drawing.Size(cardSize, cardSize);
            Name = "Card" + posX + posY;
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            TabIndex = 0;
            Image = back;
            this.Click += new System.EventHandler(HandleEventClick); //HandleEventClick is the method to handle the click
        }

        public Image Back
        {
            get { return back; }
            set { back = value; }
        }

        public Image Front
        {
            get { return front; }
            set { front = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Flipped
        {
            get { return flipped; }
            set { flipped = value; }
        }
    }
}
