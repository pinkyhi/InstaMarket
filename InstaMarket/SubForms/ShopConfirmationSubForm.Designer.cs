namespace InstaMarket.SubForms
{
    partial class ShopConfirmationSubForm
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
            this.shopPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shopPictureBox
            // 
            this.shopPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shopPictureBox.Location = new System.Drawing.Point(52, 57);
            this.shopPictureBox.Name = "shopPictureBox";
            this.shopPictureBox.Size = new System.Drawing.Size(190, 190);
            this.shopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shopPictureBox.TabIndex = 0;
            this.shopPictureBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(47, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(127, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "USERNAME";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(52, 254);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(66, 18);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "FullName";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(55, 276);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(187, 30);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "It\'s what i want!";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // ShopConfirmationSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(295, 341);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.shopPictureBox);
            this.Name = "ShopConfirmationSubForm";
            this.Text = "ShopConfirmationSubForm";
            ((System.ComponentModel.ISupportInitialize)(this.shopPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox shopPictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button confirmButton;
    }
}