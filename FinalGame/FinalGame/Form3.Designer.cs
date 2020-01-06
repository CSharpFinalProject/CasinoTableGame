namespace FinalGame
{
    partial class horseRacingForm
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
            this.horseThree = new System.Windows.Forms.Label();
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
            this.welcomeToHorseRacingLabel.Location = new System.Drawing.Point(301, 9);
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
            this.horseOne.Location = new System.Drawing.Point(13, 214);
            this.horseOne.Name = "horseOne";
            this.horseOne.Size = new System.Drawing.Size(44, 13);
            this.horseOne.TabIndex = 4;
            this.horseOne.Text = "Lighting";
            // 
            // horseTwo
            // 
            this.horseTwo.AutoSize = true;
            this.horseTwo.Location = new System.Drawing.Point(13, 412);
            this.horseTwo.Name = "horseTwo";
            this.horseTwo.Size = new System.Drawing.Size(47, 13);
            this.horseTwo.TabIndex = 5;
            this.horseTwo.Text = "Thunder";
            // 
            // horseThree
            // 
            this.horseThree.AutoSize = true;
            this.horseThree.Location = new System.Drawing.Point(13, 630);
            this.horseThree.Name = "horseThree";
            this.horseThree.Size = new System.Drawing.Size(43, 13);
            this.horseThree.TabIndex = 6;
            this.horseThree.Text = "Bumper";
            // 
            // horseRacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1984, 1054);
            this.Controls.Add(this.horseThree);
            this.Controls.Add(this.horseTwo);
            this.Controls.Add(this.horseOne);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeToHorseRacingLabel);
            this.Name = "horseRacingForm";
            this.Text = "Horse Racing Betting";
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
        private System.Windows.Forms.Label horseThree;
    }
}