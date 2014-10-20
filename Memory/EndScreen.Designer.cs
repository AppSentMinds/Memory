namespace Memory
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.gbEndScreen = new System.Windows.Forms.Panel();
            this.lblWinnerText = new System.Windows.Forms.Label();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnRematch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gbEndScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEndScreen
            // 
            this.gbEndScreen.BackColor = System.Drawing.Color.Transparent;
            this.gbEndScreen.BackgroundImage = global::Memory.Properties.Resources._50procent_opt;
            this.gbEndScreen.Controls.Add(this.lblWinnerText);
            this.gbEndScreen.Controls.Add(this.btnEndGame);
            this.gbEndScreen.Controls.Add(this.btnMainMenu);
            this.gbEndScreen.Controls.Add(this.btnRematch);
            this.gbEndScreen.Controls.Add(this.label10);
            this.gbEndScreen.Location = new System.Drawing.Point(22, 23);
            this.gbEndScreen.Name = "gbEndScreen";
            this.gbEndScreen.Size = new System.Drawing.Size(274, 324);
            this.gbEndScreen.TabIndex = 14;
            // 
            // lblWinnerText
            // 
            this.lblWinnerText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWinnerText.AutoSize = true;
            this.lblWinnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerText.ForeColor = System.Drawing.Color.White;
            this.lblWinnerText.Location = new System.Drawing.Point(70, 62);
            this.lblWinnerText.Name = "lblWinnerText";
            this.lblWinnerText.Size = new System.Drawing.Size(85, 20);
            this.lblWinnerText.TabIndex = 9;
            this.lblWinnerText.Text = "Winnertext";
            this.lblWinnerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.Location = new System.Drawing.Point(184, 254);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(79, 29);
            this.btnEndGame.TabIndex = 7;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(9, 221);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(81, 29);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnRematch
            // 
            this.btnRematch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRematch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRematch.Location = new System.Drawing.Point(9, 254);
            this.btnRematch.Name = "btnRematch";
            this.btnRematch.Size = new System.Drawing.Size(81, 29);
            this.btnRematch.TabIndex = 7;
            this.btnRematch.Text = "Rematch";
            this.btnRematch.UseVisualStyleBackColor = false;
            this.btnRematch.Click += new System.EventHandler(this.btnRematch_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(71, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "This game was brought to \r\n you by AppSentMinds();";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.blessing_olive_green_design_opt;
            this.ClientSize = new System.Drawing.Size(318, 372);
            this.Controls.Add(this.gbEndScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Result";
            this.gbEndScreen.ResumeLayout(false);
            this.gbEndScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gbEndScreen;
        private System.Windows.Forms.Label lblWinnerText;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnRematch;
        private System.Windows.Forms.Label label10;
    }
}