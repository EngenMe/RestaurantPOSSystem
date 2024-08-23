namespace POSResturant.Forms
{
    partial class FrmPaymentsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPaymentsList = new System.Windows.Forms.DataGridView();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterMethod = new System.Windows.Forms.ComboBox();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaymentsList
            // 
            this.dgvPaymentsList.AllowUserToAddRows = false;
            this.dgvPaymentsList.AllowUserToDeleteRows = false;
            this.dgvPaymentsList.AllowUserToOrderColumns = true;
            this.dgvPaymentsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPaymentsList.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvPaymentsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaymentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaymentsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPaymentsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.dgvPaymentsList.Location = new System.Drawing.Point(0, 150);
            this.dgvPaymentsList.Name = "dgvPaymentsList";
            this.dgvPaymentsList.ReadOnly = true;
            this.dgvPaymentsList.RowHeadersWidth = 51;
            this.dgvPaymentsList.RowTemplate.Height = 24;
            this.dgvPaymentsList.Size = new System.Drawing.Size(1062, 560);
            this.dgvPaymentsList.TabIndex = 0;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Beige;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterBy.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(42, 72);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(209, 32);
            this.cbFilterBy.TabIndex = 1;
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.Beige;
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(301, 71);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(275, 30);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(811, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 74);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payments\r\n              List";
            // 
            // cbFilterMethod
            // 
            this.cbFilterMethod.BackColor = System.Drawing.Color.Beige;
            this.cbFilterMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterMethod.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterMethod.FormattingEnabled = true;
            this.cbFilterMethod.Location = new System.Drawing.Point(301, 72);
            this.cbFilterMethod.Name = "cbFilterMethod";
            this.cbFilterMethod.Size = new System.Drawing.Size(275, 32);
            this.cbFilterMethod.TabIndex = 1;
            this.cbFilterMethod.Visible = false;
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.BackColor = System.Drawing.Color.Beige;
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilterStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Location = new System.Drawing.Point(301, 72);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(275, 32);
            this.cbFilterStatus.TabIndex = 1;
            this.cbFilterStatus.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.lblYear.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Beige;
            this.lblYear.Location = new System.Drawing.Point(339, 45);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 20);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            this.lblYear.Visible = false;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.lblMonth.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Beige;
            this.lblMonth.Location = new System.Drawing.Point(442, 45);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(58, 20);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Month";
            this.lblMonth.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.lblDay.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Beige;
            this.lblDay.Location = new System.Drawing.Point(550, 45);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 20);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Day";
            this.lblDay.Visible = false;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.lblHour.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Beige;
            this.lblHour.Location = new System.Drawing.Point(642, 45);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(46, 20);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hour";
            this.lblHour.Visible = false;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Beige;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(301, 72);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(119, 32);
            this.cbYear.TabIndex = 1;
            this.cbYear.Visible = false;
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.Beige;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonth.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(426, 72);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(91, 32);
            this.cbMonth.TabIndex = 1;
            this.cbMonth.Visible = false;
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.Beige;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDay.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(523, 72);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(91, 32);
            this.cbDay.TabIndex = 1;
            this.cbDay.Visible = false;
            // 
            // cbHour
            // 
            this.cbHour.BackColor = System.Drawing.Color.Beige;
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHour.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(620, 72);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(91, 32);
            this.cbHour.TabIndex = 1;
            this.cbHour.Visible = false;
            // 
            // FrmPaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.cbFilterMethod);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.dgvPaymentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPaymentsList";
            this.ShowIcon = false;
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.FrmPaymentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPaymentsList;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterMethod;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbHour;
    }
}