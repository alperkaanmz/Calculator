namespace CalculatorForms
{
    partial class secondForm
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.clearHistory = new System.Windows.Forms.Button();
            this.deleteLastEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(501, 315);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // clearHistory
            // 
            this.clearHistory.BackColor = System.Drawing.Color.Crimson;
            this.clearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearHistory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearHistory.Location = new System.Drawing.Point(344, 12);
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Size = new System.Drawing.Size(169, 42);
            this.clearHistory.TabIndex = 1;
            this.clearHistory.Text = "Geçmişi Temizle";
            this.clearHistory.UseVisualStyleBackColor = false;
            this.clearHistory.Click += new System.EventHandler(this.clearHistory_Click);
            // 
            // deleteLastEntry
            // 
            this.deleteLastEntry.BackColor = System.Drawing.Color.CadetBlue;
            this.deleteLastEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteLastEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteLastEntry.Location = new System.Drawing.Point(12, 13);
            this.deleteLastEntry.Name = "deleteLastEntry";
            this.deleteLastEntry.Size = new System.Drawing.Size(143, 42);
            this.deleteLastEntry.TabIndex = 2;
            this.deleteLastEntry.Text = "Son İşlemi Sil";
            this.deleteLastEntry.UseVisualStyleBackColor = false;
            this.deleteLastEntry.Click += new System.EventHandler(this.deleteLastEntry_Click);
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(530, 390);
            this.Controls.Add(this.deleteLastEntry);
            this.Controls.Add(this.clearHistory);
            this.Controls.Add(this.dataGridViewHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "secondForm";
            this.Text = "secondForm";
            this.Load += new System.EventHandler(this.secondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Button clearHistory;
        private System.Windows.Forms.Button deleteLastEntry;
    }
}