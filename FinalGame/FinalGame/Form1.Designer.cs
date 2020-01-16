﻿namespace FinalGame
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
            this.blackJackButton = new System.Windows.Forms.Button();
            this.horseRacing = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directionLabel
            // 
            this.directionLabel.BackColor = System.Drawing.Color.Black;
            this.directionLabel.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.directionLabel.Location = new System.Drawing.Point(51, 49);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(594, 40);
            this.directionLabel.TabIndex = 1;
            this.directionLabel.Text = "Please Choose a Game you want to play";
            // 
            // blackJackButton
            // 
            this.blackJackButton.BackColor = System.Drawing.Color.Black;
            this.blackJackButton.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackJackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.blackJackButton.Location = new System.Drawing.Point(59, 245);
            this.blackJackButton.Name = "blackJackButton";
            this.blackJackButton.Size = new System.Drawing.Size(178, 46);
            this.blackJackButton.TabIndex = 2;
            this.blackJackButton.Text = "Blackjack";
            this.blackJackButton.UseVisualStyleBackColor = false;
            this.blackJackButton.Click += new System.EventHandler(this.pokerButton_Click);
            // 
            // horseRacing
            // 
            this.horseRacing.BackColor = System.Drawing.Color.Black;
            this.horseRacing.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horseRacing.ForeColor = System.Drawing.SystemColors.Control;
            this.horseRacing.Location = new System.Drawing.Point(415, 245);
            this.horseRacing.Name = "horseRacing";
            this.horseRacing.Size = new System.Drawing.Size(230, 46);
            this.horseRacing.TabIndex = 3;
            this.horseRacing.Text = "Horse Racing";
            this.horseRacing.UseVisualStyleBackColor = false;
            this.horseRacing.Click += new System.EventHandler(this.sportsBetting_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomeLabel.Location = new System.Drawing.Point(164, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(355, 40);
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Text = "Welcome to Our Casino";
            // 
            // welcomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.horseRacing);
            this.Controls.Add(this.blackJackButton);
            this.Controls.Add(this.directionLabel);
            this.Name = "welcomForm";
            this.Text = "Welcome to Our Casino";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Button blackJackButton;
        private System.Windows.Forms.Button horseRacing;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

