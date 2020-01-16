namespace FinalGame
{
    partial class w
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
            this.welcomeToHorseRacingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.horseOne = new System.Windows.Forms.Label();
            this.horseTwo = new System.Windows.Forms.Label();
            this.instructionsForBetting = new System.Windows.Forms.Label();
            this.horseThree = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startRaceButton = new System.Windows.Forms.Button();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeToHorseRacingLabel
            // 
            this.welcomeToHorseRacingLabel.AutoSize = true;
            this.welcomeToHorseRacingLabel.BackColor = System.Drawing.Color.White;
            this.welcomeToHorseRacingLabel.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeToHorseRacingLabel.Location = new System.Drawing.Point(537, 9);
            this.welcomeToHorseRacingLabel.Name = "welcomeToHorseRacingLabel";
            this.welcomeToHorseRacingLabel.Size = new System.Drawing.Size(388, 42);
            this.welcomeToHorseRacingLabel.TabIndex = 0;
            this.welcomeToHorseRacingLabel.Text = "Welcome to Horse Racing!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalGame.Properties.Resources.horseRunning;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FinalGame.Properties.Resources.horseRunning;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(12, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 144);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::FinalGame.Properties.Resources.horseRunning;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(12, 466);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(289, 157);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // horseOne
            // 
            this.horseOne.AutoSize = true;
            this.horseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseOne.Location = new System.Drawing.Point(13, 214);
            this.horseOne.Name = "horseOne";
            this.horseOne.Size = new System.Drawing.Size(80, 25);
            this.horseOne.TabIndex = 4;
            this.horseOne.Text = "Lighting";
            // 
            // horseTwo
            // 
            this.horseTwo.AutoSize = true;
            this.horseTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseTwo.Location = new System.Drawing.Point(13, 412);
            this.horseTwo.Name = "horseTwo";
            this.horseTwo.Size = new System.Drawing.Size(86, 25);
            this.horseTwo.TabIndex = 5;
            this.horseTwo.Text = "Thunder";
            // 
            // instructionsForBetting
            // 
            this.instructionsForBetting.AutoSize = true;
            this.instructionsForBetting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.instructionsForBetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsForBetting.ForeColor = System.Drawing.Color.Black;
            this.instructionsForBetting.Location = new System.Drawing.Point(12, 743);
            this.instructionsForBetting.Name = "instructionsForBetting";
            this.instructionsForBetting.Size = new System.Drawing.Size(306, 25);
            this.instructionsForBetting.TabIndex = 8;
            this.instructionsForBetting.Text = "Enter a Bet that is from $10 - $100";
            // 
            // horseThree
            // 
            this.horseThree.AutoSize = true;
            this.horseThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseThree.Location = new System.Drawing.Point(15, 626);
            this.horseThree.Name = "horseThree";
            this.horseThree.Size = new System.Drawing.Size(80, 25);
            this.horseThree.TabIndex = 11;
            this.horseThree.Text = "Bumper";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 748);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // startRaceButton
            // 
            this.startRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRaceButton.Location = new System.Drawing.Point(479, 643);
            this.startRaceButton.Name = "startRaceButton";
            this.startRaceButton.Size = new System.Drawing.Size(138, 53);
            this.startRaceButton.TabIndex = 13;
            this.startRaceButton.Text = "Start Race";
            this.startRaceButton.UseVisualStyleBackColor = true;
            this.startRaceButton.Click += new System.EventHandler(this.startRaceButton_Click);
            // 
            // winningsLabel
            // 
            this.winningsLabel.AutoSize = true;
            this.winningsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningsLabel.Location = new System.Drawing.Point(118, 766);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(60, 25);
            this.winningsLabel.TabIndex = 14;
            this.winningsLabel.Text = "Won!";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 771);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 724);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 718);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter the Horse You Want to Win";
            // 
            // w
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 962);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.winningsLabel);
            this.Controls.Add(this.startRaceButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.horseThree);
            this.Controls.Add(this.instructionsForBetting);
            this.Controls.Add(this.horseTwo);
            this.Controls.Add(this.horseOne);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeToHorseRacingLabel);
            this.Name = "w";
            this.Text = "Horse Racing Betting";
            this.Load += new System.EventHandler(this.w_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeToHorseRacingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label horseOne;
        private System.Windows.Forms.Label horseTwo;
        private System.Windows.Forms.Label instructionsForBetting;
        private System.Windows.Forms.Label horseThree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startRaceButton;
        private System.Windows.Forms.Label winningsLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}