namespace InstaMarket
{
    partial class VoluntarySqlRequestForm
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
            this.sqlRequestRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doSqlButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.schemaButton = new System.Windows.Forms.Button();
            this.voluntaryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.voluntaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlRequestRichTextBox
            // 
            this.sqlRequestRichTextBox.Location = new System.Drawing.Point(13, 13);
            this.sqlRequestRichTextBox.Name = "sqlRequestRichTextBox";
            this.sqlRequestRichTextBox.Size = new System.Drawing.Size(662, 165);
            this.sqlRequestRichTextBox.TabIndex = 0;
            this.sqlRequestRichTextBox.Text = "";
            // 
            // doSqlButton
            // 
            this.doSqlButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doSqlButton.Location = new System.Drawing.Point(682, 13);
            this.doSqlButton.Name = "doSqlButton";
            this.doSqlButton.Size = new System.Drawing.Size(134, 50);
            this.doSqlButton.TabIndex = 1;
            this.doSqlButton.Text = "DO SQL";
            this.doSqlButton.UseVisualStyleBackColor = true;
            this.doSqlButton.Click += new System.EventHandler(this.doSqlButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(681, 69);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(134, 50);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // schemaButton
            // 
            this.schemaButton.Font = new System.Drawing.Font("Reload Alt Cyrilic by STELORQ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemaButton.Location = new System.Drawing.Point(681, 128);
            this.schemaButton.Name = "schemaButton";
            this.schemaButton.Size = new System.Drawing.Size(134, 50);
            this.schemaButton.TabIndex = 1;
            this.schemaButton.Text = "SCHEMA";
            this.schemaButton.UseVisualStyleBackColor = true;
            this.schemaButton.Click += new System.EventHandler(this.schemaButton_Click);
            // 
            // voluntaryDataGridView
            // 
            this.voluntaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voluntaryDataGridView.Location = new System.Drawing.Point(13, 185);
            this.voluntaryDataGridView.Name = "voluntaryDataGridView";
            this.voluntaryDataGridView.Size = new System.Drawing.Size(802, 275);
            this.voluntaryDataGridView.TabIndex = 2;
            // 
            // VoluntarySqlRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 472);
            this.Controls.Add(this.voluntaryDataGridView);
            this.Controls.Add(this.schemaButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doSqlButton);
            this.Controls.Add(this.sqlRequestRichTextBox);
            this.Name = "VoluntarySqlRequestForm";
            this.Text = "VoluntarySqlRequest";
            ((System.ComponentModel.ISupportInitialize)(this.voluntaryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox sqlRequestRichTextBox;
        private System.Windows.Forms.Button doSqlButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button schemaButton;
        private System.Windows.Forms.DataGridView voluntaryDataGridView;
    }
}