namespace ConstructionWindowApp
{
    partial class UC_Client
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClientDataTable = new System.Windows.Forms.DataGridView();
            this.UC_AddClient = new ConstructionWindowApp.UC_AddClient();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(272, 504);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(216, 38);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "ADD CLIENT DETAILS";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClientDataTable
            // 
            this.ClientDataTable.AllowUserToAddRows = false;
            this.ClientDataTable.AllowUserToDeleteRows = false;
            this.ClientDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataTable.Location = new System.Drawing.Point(8, 38);
            this.ClientDataTable.Name = "ClientDataTable";
            this.ClientDataTable.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(140)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ClientDataTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataTable.Size = new System.Drawing.Size(746, 445);
            this.ClientDataTable.TabIndex = 6;
            // 
            // UC_AddClient
            // 
            this.UC_AddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(213)))));
            this.UC_AddClient.Location = new System.Drawing.Point(190, 95);
            this.UC_AddClient.Name = "UC_AddClient";
            this.UC_AddClient.Size = new System.Drawing.Size(353, 310);
            this.UC_AddClient.TabIndex = 7;
            // 
            // UC_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(140)))), ((int)(((byte)(156)))));
            this.Controls.Add(this.UC_AddClient);
            this.Controls.Add(this.ClientDataTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Name = "UC_Client";
            this.Size = new System.Drawing.Size(766, 562);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView ClientDataTable;
        private UC_AddClient UC_AddClient;
    }
}
