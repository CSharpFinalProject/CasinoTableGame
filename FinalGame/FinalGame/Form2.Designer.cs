namespace FinalGame
{
    partial class playingPokerForm
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
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.dealerCardOne = new System.Windows.Forms.Label();
            this.dealerCardTwo = new System.Windows.Forms.Label();
            this.dealerCardThree = new System.Windows.Forms.Label();
            this.cardThree = new System.Windows.Forms.Label();
            this.cardOne = new System.Windows.Forms.Label();
            this.cardTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hitButton.Location = new System.Drawing.Point(87, 421);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(99, 47);
            this.hitButton.TabIndex = 0;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.standButton.Location = new System.Drawing.Point(618, 421);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(127, 47);
            this.standButton.TabIndex = 1;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // dealerCardOne
            // 
            this.dealerCardOne.AutoSize = true;
            this.dealerCardOne.Location = new System.Drawing.Point(327, 75);
            this.dealerCardOne.Name = "dealerCardOne";
            this.dealerCardOne.Size = new System.Drawing.Size(35, 13);
            this.dealerCardOne.TabIndex = 2;
            this.dealerCardOne.Text = "label1";
            // 
            // dealerCardTwo
            // 
            this.dealerCardTwo.AutoSize = true;
            this.dealerCardTwo.Location = new System.Drawing.Point(410, 43);
            this.dealerCardTwo.Name = "dealerCardTwo";
            this.dealerCardTwo.Size = new System.Drawing.Size(35, 13);
            this.dealerCardTwo.TabIndex = 3;
            this.dealerCardTwo.Text = "label2";
            // 
            // dealerCardThree
            // 
            this.dealerCardThree.AutoSize = true;
            this.dealerCardThree.Location = new System.Drawing.Point(500, 75);
            this.dealerCardThree.Name = "dealerCardThree";
            this.dealerCardThree.Size = new System.Drawing.Size(35, 13);
            this.dealerCardThree.TabIndex = 4;
            this.dealerCardThree.Text = "label3";
            // 
            // cardThree
            // 
            this.cardThree.AutoSize = true;
            this.cardThree.Location = new System.Drawing.Point(327, 455);
            this.cardThree.Name = "cardThree";
            this.cardThree.Size = new System.Drawing.Size(35, 13);
            this.cardThree.TabIndex = 5;
            this.cardThree.Text = "label4";
            // 
            // cardOne
            // 
            this.cardOne.AutoSize = true;
            this.cardOne.Location = new System.Drawing.Point(410, 479);
            this.cardOne.Name = "cardOne";
            this.cardOne.Size = new System.Drawing.Size(39, 13);
            this.cardOne.TabIndex = 6;
            this.cardOne.Text = "Label1";
            // 
            // cardTwo
            // 
            this.cardTwo.AutoSize = true;
            this.cardTwo.Location = new System.Drawing.Point(499, 454);
            this.cardTwo.Name = "cardTwo";
            this.cardTwo.Size = new System.Drawing.Size(35, 13);
            this.cardTwo.TabIndex = 7;
            this.cardTwo.Text = "label6";
            // 
            // playingPokerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalGame.Properties.Resources.blackjake;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 516);
            this.Controls.Add(this.cardTwo);
            this.Controls.Add(this.cardOne);
            this.Controls.Add(this.cardThree);
            this.Controls.Add(this.dealerCardThree);
            this.Controls.Add(this.dealerCardTwo);
            this.Controls.Add(this.dealerCardOne);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "playingPokerForm";
            this.Text = "Playing Poker";
            this.Load += new System.EventHandler(this.playingPokerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label dealerCardOne;
        private System.Windows.Forms.Label dealerCardTwo;
        private System.Windows.Forms.Label dealerCardThree;
        private System.Windows.Forms.Label cardThree;
        private System.Windows.Forms.Label cardOne;
        private System.Windows.Forms.Label cardTwo;
    }
}