namespace InstaMarket.SubForms
{
    partial class ShopAddSubForm
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
            this.findAccountButton = new System.Windows.Forms.Button();
            this.shopAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findAccountButton
            // 
            this.findAccountButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findAccountButton.Location = new System.Drawing.Point(406, 68);
            this.findAccountButton.Name = "findAccountButton";
            this.findAccountButton.Size = new System.Drawing.Size(154, 39);
            this.findAccountButton.TabIndex = 0;
            this.findAccountButton.Text = "Find account";
            this.findAccountButton.UseVisualStyleBackColor = true;
            this.findAccountButton.Click += new System.EventHandler(this.findAccountButton_Click);
            // 
            // shopAccountNameTextBox
            // 
            this.shopAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopAccountNameTextBox.Location = new System.Drawing.Point(170, 76);
            this.shopAccountNameTextBox.MaxLength = 64;
            this.shopAccountNameTextBox.Name = "shopAccountNameTextBox";
            this.shopAccountNameTextBox.Size = new System.Drawing.Size(230, 26);
            this.shopAccountNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adding the shop account";
            // 
            // ShopAddSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(583, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shopAccountNameTextBox);
            this.Controls.Add(this.findAccountButton);
            this.Name = "ShopAddSubForm";
            this.Text = "ShopSubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findAccountButton;
        private System.Windows.Forms.TextBox shopAccountNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}