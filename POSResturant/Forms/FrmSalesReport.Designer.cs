namespace POSResturant.Forms
{
    partial class FrmSalesReport
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
            this.rvSalesReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvSalesReport
            // 
            this.rvSalesReport.BackColor = System.Drawing.Color.Beige;
            this.rvSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvSalesReport.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvSalesReport.Location = new System.Drawing.Point(0, 0);
            this.rvSalesReport.Name = "rvSalesReport";
            this.rvSalesReport.ServerReport.BearerToken = null;
            this.rvSalesReport.Size = new System.Drawing.Size(1062, 710);
            this.rvSalesReport.TabIndex = 0;
            // 
            // FrmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.rvSalesReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSalesReport";
            this.ShowIcon = false;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.FrmSalesReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvSalesReport;
    }
}