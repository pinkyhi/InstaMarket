namespace InstaMarket.SubForms
{
    partial class GoodDimensionEditSubForm
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
            this.goodDimensionIdLabel = new System.Windows.Forms.Label();
            this.goodIdLabel = new System.Windows.Forms.Label();
            this.goodLabel = new System.Windows.Forms.Label();
            this.dimensionIdLabel = new System.Windows.Forms.Label();
            this.dimensionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // goodDimensionIdLabel
            // 
            this.goodDimensionIdLabel.AutoSize = true;
            this.goodDimensionIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodDimensionIdLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodDimensionIdLabel.Location = new System.Drawing.Point(12, 9);
            this.goodDimensionIdLabel.Name = "goodDimensionIdLabel";
            this.goodDimensionIdLabel.Size = new System.Drawing.Size(173, 31);
            this.goodDimensionIdLabel.TabIndex = 0;
            this.goodDimensionIdLabel.Text = "Vendor Code: ";
            // 
            // goodIdLabel
            // 
            this.goodIdLabel.AutoSize = true;
            this.goodIdLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodIdLabel.Location = new System.Drawing.Point(22, 50);
            this.goodIdLabel.Name = "goodIdLabel";
            this.goodIdLabel.Size = new System.Drawing.Size(86, 23);
            this.goodIdLabel.TabIndex = 0;
            this.goodIdLabel.Text = "Good ID: ";
            // 
            // goodLabel
            // 
            this.goodLabel.AutoSize = true;
            this.goodLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodLabel.Location = new System.Drawing.Point(22, 81);
            this.goodLabel.Name = "goodLabel";
            this.goodLabel.Size = new System.Drawing.Size(64, 23);
            this.goodLabel.TabIndex = 0;
            this.goodLabel.Text = "Good: ";
            // 
            // dimensionIdLabel
            // 
            this.dimensionIdLabel.AutoSize = true;
            this.dimensionIdLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionIdLabel.Location = new System.Drawing.Point(22, 110);
            this.dimensionIdLabel.Name = "dimensionIdLabel";
            this.dimensionIdLabel.Size = new System.Drawing.Size(135, 23);
            this.dimensionIdLabel.TabIndex = 0;
            this.dimensionIdLabel.Text = "Dimension ID: ";
            // 
            // dimensionLabel
            // 
            this.dimensionLabel.AutoSize = true;
            this.dimensionLabel.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionLabel.Location = new System.Drawing.Point(22, 141);
            this.dimensionLabel.Name = "dimensionLabel";
            this.dimensionLabel.Size = new System.Drawing.Size(113, 23);
            this.dimensionLabel.TabIndex = 0;
            this.dimensionLabel.Text = "Dimension: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(110, 174);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(127, 20);
            this.priceNumericUpDown.TabIndex = 2;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(117, 203);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountNumericUpDown.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoodDimensionEditSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(429, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimensionLabel);
            this.Controls.Add(this.goodLabel);
            this.Controls.Add(this.dimensionIdLabel);
            this.Controls.Add(this.goodIdLabel);
            this.Controls.Add(this.goodDimensionIdLabel);
            this.Name = "GoodDimensionEditSubForm";
            this.Text = "GoodDimensionEditSubForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goodDimensionIdLabel;
        private System.Windows.Forms.Label goodIdLabel;
        private System.Windows.Forms.Label goodLabel;
        private System.Windows.Forms.Label dimensionIdLabel;
        private System.Windows.Forms.Label dimensionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button button1;
    }
}