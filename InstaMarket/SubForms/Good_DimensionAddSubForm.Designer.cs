namespace InstaMarket.SubForms
{
    partial class Good_DimensionAddSubForm
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
            this.vendorGoodsDataGridView = new System.Windows.Forms.DataGridView();
            this.vendorDimensionsDataGridView = new System.Windows.Forms.DataGridView();
            this.boundVendorCodesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorGoodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDimensionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorGoodsDataGridView
            // 
            this.vendorGoodsDataGridView.AllowUserToAddRows = false;
            this.vendorGoodsDataGridView.AllowUserToDeleteRows = false;
            this.vendorGoodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorGoodsDataGridView.Location = new System.Drawing.Point(13, 51);
            this.vendorGoodsDataGridView.Name = "vendorGoodsDataGridView";
            this.vendorGoodsDataGridView.ReadOnly = true;
            this.vendorGoodsDataGridView.Size = new System.Drawing.Size(387, 318);
            this.vendorGoodsDataGridView.TabIndex = 0;
            // 
            // vendorDimensionsDataGridView
            // 
            this.vendorDimensionsDataGridView.AllowUserToAddRows = false;
            this.vendorDimensionsDataGridView.AllowUserToDeleteRows = false;
            this.vendorDimensionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDimensionsDataGridView.Location = new System.Drawing.Point(406, 51);
            this.vendorDimensionsDataGridView.Name = "vendorDimensionsDataGridView";
            this.vendorDimensionsDataGridView.ReadOnly = true;
            this.vendorDimensionsDataGridView.Size = new System.Drawing.Size(387, 318);
            this.vendorDimensionsDataGridView.TabIndex = 0;
            // 
            // boundVendorCodesButton
            // 
            this.boundVendorCodesButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.boundVendorCodesButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boundVendorCodesButton.Location = new System.Drawing.Point(234, 376);
            this.boundVendorCodesButton.Name = "boundVendorCodesButton";
            this.boundVendorCodesButton.Size = new System.Drawing.Size(343, 62);
            this.boundVendorCodesButton.TabIndex = 1;
            this.boundVendorCodesButton.Text = "Bound vendor codes";
            this.boundVendorCodesButton.UseVisualStyleBackColor = false;
            this.boundVendorCodesButton.Click += new System.EventHandler(this.boundVendorCodesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(400, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dimensions";
            // 
            // Good_DimensionAddSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boundVendorCodesButton);
            this.Controls.Add(this.vendorDimensionsDataGridView);
            this.Controls.Add(this.vendorGoodsDataGridView);
            this.Name = "Good_DimensionAddSubForm";
            this.Text = "Good_DimensionSubForm";
            ((System.ComponentModel.ISupportInitialize)(this.vendorGoodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDimensionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendorGoodsDataGridView;
        private System.Windows.Forms.DataGridView vendorDimensionsDataGridView;
        private System.Windows.Forms.Button boundVendorCodesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}