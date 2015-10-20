namespace Rhenium.Client
{
    partial class RheniumLeague
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button CreateSqlServerDb;
        private System.Windows.Forms.Button generateJsonReportBtn;

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
            this.CreateSqlServerDb = new System.Windows.Forms.Button();
            this.generateJsonReportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateSqlServerDb
            // 
            this.CreateSqlServerDb.Location = new System.Drawing.Point(12, 12);
            this.CreateSqlServerDb.Name = "CreateSqlServerDb";
            this.CreateSqlServerDb.Size = new System.Drawing.Size(132, 23);
            this.CreateSqlServerDb.TabIndex = 0;
            this.CreateSqlServerDb.Text = "Create SQL Server DB";
            this.CreateSqlServerDb.UseVisualStyleBackColor = true;
            this.CreateSqlServerDb.Click += new System.EventHandler(this.CreateSqlServerDb_Click);
            // 
            // generateJsonReportBtn
            // 
            this.generateJsonReportBtn.Location = new System.Drawing.Point(12, 61);
            this.generateJsonReportBtn.Name = "generateJsonReportBtn";
            this.generateJsonReportBtn.Size = new System.Drawing.Size(163, 29);
            this.generateJsonReportBtn.TabIndex = 5;
            this.generateJsonReportBtn.Text = "Generate Json report";
            this.generateJsonReportBtn.UseVisualStyleBackColor = false;
            this.generateJsonReportBtn.Click += new System.EventHandler(this.GenerateJsonReport_btn_Click);
            // 
            // RheniumLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CreateSqlServerDb);
            this.Controls.Add(this.generateJsonReportBtn);
            this.Name = "RheniumLeague";
            this.Text = "RheniumLeague";
            this.ResumeLayout(false);

        }

        #endregion

       
    }
}

