namespace POSResturant.Forms
{
    partial class FrmSalesReportDetailed
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
            this.rvSalesReportDetailed = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvSalesReportDetailed
            // 
            this.rvSalesReportDetailed.BackColor = System.Drawing.Color.Beige;
            this.rvSalesReportDetailed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvSalesReportDetailed.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvSalesReportDetailed.Location = new System.Drawing.Point(0, 0);
            this.rvSalesReportDetailed.Name = "rvSalesReportDetailed";
            this.rvSalesReportDetailed.ServerReport.BearerToken = null;
            this.rvSalesReportDetailed.Size = new System.Drawing.Size(1062, 710);
            this.rvSalesReportDetailed.TabIndex = 0;
            // 
            // FrmSalesReportDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.rvSalesReportDetailed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSalesReportDetailed";
            this.ShowIcon = false;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.FrmSalesReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvSalesReportDetailed;
    }
}