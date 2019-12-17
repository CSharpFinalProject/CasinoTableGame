namespace FinalGame
{
    partial class welcomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomForm));
            this.directionLabel = new System.Windows.Forms.Label();
            this.pokerButton = new System.Windows.Forms.Button();
            this.sportsBetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directionLabel
            // 
            this.directionLabel.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(51, 49);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(594, 40);
            this.directionLabel.TabIndex = 1;
            this.directionLabel.Text = "Please Choose a Game you want to play";
            // 
            // pokerButton
            // 
            this.pokerButton.BackColor = System.Drawing.Color.Silver;
            this.pokerButton.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokerButton.Location = new System.Drawing.Point(59, 245);
            this.pokerButton.Name = "pokerButton";
            this.pokerButton.Size = new System.Drawing.Size(117, 46);
            this.pokerButton.TabIndex = 2;
            this.pokerButton.Text = "Poker";
            this.pokerButton.UseVisualStyleBackColor = false;
            this.pokerButton.Click += new System.EventHandler(this.pokerButton_Click);
            // 
            // sportsBetting
            // 
            this.sportsBetting.BackColor = System.Drawing.Color.Silver;
            this.sportsBetting.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportsBetting.Location = new System.Drawing.Point(415, 245);
            this.sportsBetting.Name = "sportsBetting";
            this.sportsBetting.Size = new System.Drawing.Size(230, 46);
            this.sportsBetting.TabIndex = 3;
            this.sportsBetting.Text = "Sports Betting";
            this.sportsBetting.UseVisualStyleBackColor = false;
            this.sportsBetting.Click += new System.EventHandler(this.sportsBetting_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Our Casino";
            // 
            // welcomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sportsBetting);
            this.Controls.Add(this.pokerButton);
            this.Controls.Add(this.directionLabel);
            this.Name = "welcomForm";
            this.Text = "Welcome to Our Casino";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Button pokerButton;
        private System.Windows.Forms.Button sportsBetting;
        private System.Windows.Forms.Label label1;
    }
}

