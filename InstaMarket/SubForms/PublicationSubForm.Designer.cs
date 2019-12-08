namespace InstaMarket.SubForms
{
    partial class PublicationSubForm
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
            this.publicationPictureBox = new System.Windows.Forms.PictureBox();
            this.goToLeftImageButton = new System.Windows.Forms.Button();
            this.goToRightImageButton = new System.Windows.Forms.Button();
            this.addVendorCodeButton = new System.Windows.Forms.Button();
            this.videosRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publicationGoodDimensionsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.vendorCodeTextBox = new System.Windows.Forms.TextBox();
            this.deleteVendorCodeButton = new System.Windows.Forms.Button();
            this.savePublication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publicationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationGoodDimensionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // publicationPictureBox
            // 
            this.publicationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.publicationPictureBox.Location = new System.Drawing.Point(12, 12);
            this.publicationPictureBox.Name = "publicationPictureBox";
            this.publicationPictureBox.Size = new System.Drawing.Size(250, 250);
            this.publicationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.publicationPictureBox.TabIndex = 0;
            this.publicationPictureBox.TabStop = false;
            // 
            // goToLeftImageButton
            // 
            this.goToLeftImageButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLeftImageButton.Location = new System.Drawing.Point(13, 269);
            this.goToLeftImageButton.Name = "goToLeftImageButton";
            this.goToLeftImageButton.Size = new System.Drawing.Size(125, 42);
            this.goToLeftImageButton.TabIndex = 1;
            this.goToLeftImageButton.Text = "<";
            this.goToLeftImageButton.UseVisualStyleBackColor = true;
            this.goToLeftImageButton.Click += new System.EventHandler(this.goToLeftImageButton_Click);
            // 
            // goToRightImageButton
            // 
            this.goToRightImageButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRightImageButton.Location = new System.Drawing.Point(137, 269);
            this.goToRightImageButton.Name = "goToRightImageButton";
            this.goToRightImageButton.Size = new System.Drawing.Size(125, 42);
            this.goToRightImageButton.TabIndex = 1;
            this.goToRightImageButton.Text = ">";
            this.goToRightImageButton.UseVisualStyleBackColor = true;
            this.goToRightImageButton.Click += new System.EventHandler(this.goToRightImageButton_Click);
            // 
            // addVendorCodeButton
            // 
            this.addVendorCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVendorCodeButton.Location = new System.Drawing.Point(557, 318);
            this.addVendorCodeButton.Name = "addVendorCodeButton";
            this.addVendorCodeButton.Size = new System.Drawing.Size(230, 41);
            this.addVendorCodeButton.TabIndex = 2;
            this.addVendorCodeButton.Text = "Add vendor code";
            this.addVendorCodeButton.UseVisualStyleBackColor = true;
            this.addVendorCodeButton.Click += new System.EventHandler(this.addVendorCodeButton_Click);
            // 
            // videosRichTextBox
            // 
            this.videosRichTextBox.Location = new System.Drawing.Point(269, 49);
            this.videosRichTextBox.Name = "videosRichTextBox";
            this.videosRichTextBox.Size = new System.Drawing.Size(519, 213);
            this.videosRichTextBox.TabIndex = 3;
            this.videosRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Videos in publication";
            // 
            // publicationGoodDimensionsDataGridView
            // 
            this.publicationGoodDimensionsDataGridView.AllowUserToAddRows = false;
            this.publicationGoodDimensionsDataGridView.AllowUserToDeleteRows = false;
            this.publicationGoodDimensionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.publicationGoodDimensionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicationGoodDimensionsDataGridView.Location = new System.Drawing.Point(13, 318);
            this.publicationGoodDimensionsDataGridView.Name = "publicationGoodDimensionsDataGridView";
            this.publicationGoodDimensionsDataGridView.ReadOnly = true;
            this.publicationGoodDimensionsDataGridView.Size = new System.Drawing.Size(542, 210);
            this.publicationGoodDimensionsDataGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(353, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vendor code:";
            // 
            // vendorCodeTextBox
            // 
            this.vendorCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vendorCodeTextBox.Location = new System.Drawing.Point(557, 275);
            this.vendorCodeTextBox.Name = "vendorCodeTextBox";
            this.vendorCodeTextBox.Size = new System.Drawing.Size(230, 35);
            this.vendorCodeTextBox.TabIndex = 7;
            // 
            // deleteVendorCodeButton
            // 
            this.deleteVendorCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteVendorCodeButton.Location = new System.Drawing.Point(557, 365);
            this.deleteVendorCodeButton.Name = "deleteVendorCodeButton";
            this.deleteVendorCodeButton.Size = new System.Drawing.Size(230, 41);
            this.deleteVendorCodeButton.TabIndex = 2;
            this.deleteVendorCodeButton.Text = "Delete vendor code";
            this.deleteVendorCodeButton.UseVisualStyleBackColor = true;
            this.deleteVendorCodeButton.Click += new System.EventHandler(this.deleteVendorCodeButton_Click);
            // 
            // savePublication
            // 
            this.savePublication.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.savePublication.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePublication.Location = new System.Drawing.Point(562, 481);
            this.savePublication.Name = "savePublication";
            this.savePublication.Size = new System.Drawing.Size(226, 47);
            this.savePublication.TabIndex = 8;
            this.savePublication.Text = "Save";
            this.savePublication.UseVisualStyleBackColor = false;
            this.savePublication.Click += new System.EventHandler(this.savePublication_Click);
            // 
            // PublicationSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.savePublication);
            this.Controls.Add(this.vendorCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publicationGoodDimensionsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videosRichTextBox);
            this.Controls.Add(this.deleteVendorCodeButton);
            this.Controls.Add(this.addVendorCodeButton);
            this.Controls.Add(this.goToRightImageButton);
            this.Controls.Add(this.goToLeftImageButton);
            this.Controls.Add(this.publicationPictureBox);
            this.Name = "PublicationSubForm";
            this.Text = "PublicationSubForm";
            ((System.ComponentModel.ISupportInitialize)(this.publicationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationGoodDimensionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox publicationPictureBox;
        private System.Windows.Forms.Button goToLeftImageButton;
        private System.Windows.Forms.Button goToRightImageButton;
        private System.Windows.Forms.Button addVendorCodeButton;
        private System.Windows.Forms.RichTextBox videosRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView publicationGoodDimensionsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vendorCodeTextBox;
        private System.Windows.Forms.Button deleteVendorCodeButton;
        private System.Windows.Forms.Button savePublication;
    }
}