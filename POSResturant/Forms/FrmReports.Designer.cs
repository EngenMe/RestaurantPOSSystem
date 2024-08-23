namespace POSResturant.Forms
{
    partial class FrmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReports));
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSalesReportDetailed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesReport.Image")));
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesReport.Location = new System.Drawing.Point(3, 2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(152, 98);
            this.btnSalesReport.TabIndex = 0;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(933, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 98);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSalesReportDetailed
            // 
            this.btnSalesReportDetailed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalesReportDetailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReportDetailed.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReportDetailed.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesReportDetailed.Image")));
            this.btnSalesReportDetailed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalesReportDetailed.Location = new System.Drawing.Point(161, 2);
            this.btnSalesReportDetailed.Name = "btnSalesReportDetailed";
            this.btnSalesReportDetailed.Size = new System.Drawing.Size(152, 98);
            this.btnSalesReportDetailed.TabIndex = 0;
            this.btnSalesReportDetailed.Text = "Sales Report Detailed";
            this.btnSalesReportDetailed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalesReportDetailed.UseVisualStyleBackColor = true;
            this.btnSalesReportDetailed.Click += new System.EventHandler(this.btnSalesReportDetailed_Click);
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSalesReportDetailed);
            this.Controls.Add(this.btnSalesReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.ShowIcon = false;
            this.Text = "FrmSales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSalesReportDetailed;
    }
}