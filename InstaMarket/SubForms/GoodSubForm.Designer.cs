namespace InstaMarket.SubForms
{
    partial class GoodSubForm
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
            this.components = new System.ComponentModel.Container();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.goodNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goodIdLabel = new System.Windows.Forms.Label();
            this.dimensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveGoodButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(12, 150);
            this.descriptionRichTextBox.MaxLength = 1024;
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(623, 165);
            this.descriptionRichTextBox.TabIndex = 0;
            this.descriptionRichTextBox.Text = "";
            // 
            // goodNameTextBox
            // 
            this.goodNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodNameTextBox.Location = new System.Drawing.Point(69, 93);
            this.goodNameTextBox.MaxLength = 64;
            this.goodNameTextBox.Name = "goodNameTextBox";
            this.goodNameTextBox.Size = new System.Drawing.Size(566, 26);
            this.goodNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // goodIdLabel
            // 
            this.goodIdLabel.AutoSize = true;
            this.goodIdLabel.BackColor = System.Drawing.Color.White;
            this.goodIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodIdLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodIdLabel.Location = new System.Drawing.Point(12, 9);
            this.goodIdLabel.Name = "goodIdLabel";
            this.goodIdLabel.Size = new System.Drawing.Size(120, 36);
            this.goodIdLabel.TabIndex = 4;
            this.goodIdLabel.Text = "Good Id:";
            // 
            // dimensionBindingSource
            // 
            this.dimensionBindingSource.DataSource = typeof(InstaMarket.Model.Dimension);
            // 
            // saveGoodButton
            // 
            this.saveGoodButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveGoodButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveGoodButton.Location = new System.Drawing.Point(446, 321);
            this.saveGoodButton.Name = "saveGoodButton";
            this.saveGoodButton.Size = new System.Drawing.Size(189, 36);
            this.saveGoodButton.TabIndex = 6;
            this.saveGoodButton.Text = "Save";
            this.saveGoodButton.UseVisualStyleBackColor = false;
            this.saveGoodButton.Click += new System.EventHandler(this.saveGoodButton_Click);
            // 
            // GoodSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(654, 373);
            this.Controls.Add(this.saveGoodButton);
            this.Controls.Add(this.goodIdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodNameTextBox);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Name = "GoodSubForm";
            this.Text = "GoodSubForm";
            ((System.ComponentModel.ISupportInitialize)(this.dimensionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.TextBox goodNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label goodIdLabel;
        private System.Windows.Forms.BindingSource dimensionBindingSource;
        private System.Windows.Forms.Button saveGoodButton;
    }
}