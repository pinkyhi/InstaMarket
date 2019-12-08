namespace InstaMarket.SubForms
{
    partial class DimensionSubForm
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
            this.saveDimensionButton = new System.Windows.Forms.Button();
            this.dimensionIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dimensionAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dimensionMeasureTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveDimensionButton
            // 
            this.saveDimensionButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveDimensionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveDimensionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDimensionButton.Location = new System.Drawing.Point(261, 170);
            this.saveDimensionButton.Name = "saveDimensionButton";
            this.saveDimensionButton.Size = new System.Drawing.Size(189, 36);
            this.saveDimensionButton.TabIndex = 12;
            this.saveDimensionButton.Text = "Save";
            this.saveDimensionButton.UseVisualStyleBackColor = false;
            this.saveDimensionButton.Click += new System.EventHandler(this.saveDimensionButton_Click);
            // 
            // dimensionIdLabel
            // 
            this.dimensionIdLabel.AutoSize = true;
            this.dimensionIdLabel.BackColor = System.Drawing.Color.White;
            this.dimensionIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dimensionIdLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionIdLabel.Location = new System.Drawing.Point(12, 9);
            this.dimensionIdLabel.Name = "dimensionIdLabel";
            this.dimensionIdLabel.Size = new System.Drawing.Size(187, 36);
            this.dimensionIdLabel.TabIndex = 11;
            this.dimensionIdLabel.Text = "Dimension Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            // 
            // dimensionAmountTextBox
            // 
            this.dimensionAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dimensionAmountTextBox.Location = new System.Drawing.Point(83, 93);
            this.dimensionAmountTextBox.MaxLength = 32;
            this.dimensionAmountTextBox.Name = "dimensionAmountTextBox";
            this.dimensionAmountTextBox.Size = new System.Drawing.Size(367, 26);
            this.dimensionAmountTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Measure";
            // 
            // dimensionMeasureTextBox
            // 
            this.dimensionMeasureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dimensionMeasureTextBox.Location = new System.Drawing.Point(89, 127);
            this.dimensionMeasureTextBox.MaxLength = 32;
            this.dimensionMeasureTextBox.Name = "dimensionMeasureTextBox";
            this.dimensionMeasureTextBox.Size = new System.Drawing.Size(361, 26);
            this.dimensionMeasureTextBox.TabIndex = 13;
            // 
            // DimensionSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(467, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dimensionMeasureTextBox);
            this.Controls.Add(this.saveDimensionButton);
            this.Controls.Add(this.dimensionIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimensionAmountTextBox);
            this.Name = "DimensionSubForm";
            this.Text = "DimensionSubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveDimensionButton;
        private System.Windows.Forms.Label dimensionIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dimensionAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dimensionMeasureTextBox;
    }
}