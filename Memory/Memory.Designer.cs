namespace Memory
{
    partial class Memory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbTimer = new System.Windows.Forms.PictureBox();
            this.pCards = new System.Windows.Forms.Panel();
            this.lblPlayersInGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTurn.Location = new System.Drawing.Point(216, 22);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(142, 30);
            this.lblPlayerTurn.TabIndex = 3;
            this.lblPlayerTurn.Text = "Player\'s turn";
            this.lblPlayerTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEndGame
            // 
            this.btnEndGame.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEndGame.Location = new System.Drawing.Point(12, 522);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(74, 35);
            this.btnEndGame.TabIndex = 5;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(723, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 153);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbTimer
            // 
            this.pbTimer.BackColor = System.Drawing.Color.Transparent;
            this.pbTimer.Location = new System.Drawing.Point(737, 55);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(55, 336);
            this.pbTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTimer.TabIndex = 8;
            this.pbTimer.TabStop = false;
            // 
            // pCards
            // 
            this.pCards.BackColor = System.Drawing.Color.Transparent;
            this.pCards.BackgroundImage = global::Memory.Properties.Resources._50procent_opt;
            this.pCards.Location = new System.Drawing.Point(210, 55);
            this.pCards.Name = "pCards";
            this.pCards.Size = new System.Drawing.Size(500, 500);
            this.pCards.TabIndex = 6;
            // 
            // lblPlayersInGame
            // 
            this.lblPlayersInGame.AutoSize = true;
            this.lblPlayersInGame.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayersInGame.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersInGame.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlayersInGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayersInGame.Location = new System.Drawing.Point(12, 55);
            this.lblPlayersInGame.Name = "lblPlayersInGame";
            this.lblPlayersInGame.Size = new System.Drawing.Size(154, 24);
            this.lblPlayersInGame.TabIndex = 10;
            this.lblPlayersInGame.Text = "lblPlayersInGame";
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Memory.Properties.Resources.blessing_olive_green_design_opt;
            this.ClientSize = new System.Drawing.Size(902, 574);
            this.Controls.Add(this.lblPlayersInGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.pCards);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.lblPlayerTurn);
            this.MaximizeBox = false;
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.pbTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Panel pCards;
        private System.Windows.Forms.PictureBox pbTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayersInGame;
    }
}

