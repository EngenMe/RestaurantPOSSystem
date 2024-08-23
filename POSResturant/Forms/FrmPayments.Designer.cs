namespace POSResturant.Forms
{
    partial class FrmPayments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayments));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.dtpDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.tbAmountToBePaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.tsPayments = new System.Windows.Forms.ToolStrip();
            this.epPayments = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPaidCash = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.tbPaidCash = new System.Windows.Forms.TextBox();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.tsPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Beige;
            this.pnlControls.Controls.Add(this.dtpDateAndTime);
            this.pnlControls.Controls.Add(this.cbStatus);
            this.pnlControls.Controls.Add(this.cbMethod);
            this.pnlControls.Controls.Add(this.tbPaidCash);
            this.pnlControls.Controls.Add(this.tbAmountToBePaid);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.lblChangeValue);
            this.pnlControls.Controls.Add(this.lblChange);
            this.pnlControls.Controls.Add(this.lblID);
            this.pnlControls.Controls.Add(this.lblPaidCash);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 121);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1062, 589);
            this.pnlControls.TabIndex = 6;
            // 
            // dtpDateAndTime
            // 
            this.dtpDateAndTime.CustomFormat = "dd/MM/yyyy - hh:mm";
            this.dtpDateAndTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAndTime.Location = new System.Drawing.Point(264, 196);
            this.dtpDateAndTime.Name = "dtpDateAndTime";
            this.dtpDateAndTime.Size = new System.Drawing.Size(244, 32);
            this.dtpDateAndTime.TabIndex = 27;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(264, 456);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(244, 32);
            this.cbStatus.TabIndex = 26;
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(264, 131);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(244, 32);
            this.cbMethod.TabIndex = 26;
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
            // 
            // tbAmountToBePaid
            // 
            this.tbAmountToBePaid.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmountToBePaid.Location = new System.Drawing.Point(264, 261);
            this.tbAmountToBePaid.Name = "tbAmountToBePaid";
            this.tbAmountToBePaid.Size = new System.Drawing.Size(169, 32);
            this.tbAmountToBePaid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(260, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 24);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount to be Paid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date And Time:";
            // 
            // tsbSelect
            // 
            this.tsbSelect.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(94, 118);
            this.tsbSelect.Text = "Select";
            this.tsbSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 121);
            // 
            // tsbNew
            // 
            this.tsbNew.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(94, 118);
            this.tsbNew.Text = "New";
            this.tsbNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(94, 118);
            this.tsbSave.Text = "Save";
            this.tsbSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 121);
            // 
            // tsbFirst
            // 
            this.tsbFirst.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbFirst.Image")));
            this.tsbFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirst.Name = "tsbFirst";
            this.tsbFirst.Size = new System.Drawing.Size(94, 118);
            this.tsbFirst.Text = "First";
            this.tsbFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbFirst.Click += new System.EventHandler(this.tsbFirst_Click);
            // 
            // tsbBack
            // 
            this.tsbBack.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(94, 118);
            this.tsbBack.Text = "Back";
            this.tsbBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(94, 118);
            this.tsbNext.Text = "Next";
            this.tsbNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbLast
            // 
            this.tsbLast.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbLast.Image")));
            this.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLast.Name = "tsbLast";
            this.tsbLast.Size = new System.Drawing.Size(94, 118);
            this.tsbLast.Text = "Last";
            this.tsbLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLast.Click += new System.EventHandler(this.tsbLast_Click);
            // 
            // tsPayments
            // 
            this.tsPayments.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.tsPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelect,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbFirst,
            this.tsbBack,
            this.tsbNext,
            this.tsbLast});
            this.tsPayments.Location = new System.Drawing.Point(0, 0);
            this.tsPayments.Name = "tsPayments";
            this.tsPayments.Size = new System.Drawing.Size(1062, 121);
            this.tsPayments.TabIndex = 5;
            this.tsPayments.Text = "toolStrip1";
            // 
            // epPayments
            // 
            this.epPayments.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPayments.ContainerControl = this;
            // 
            // lblPaidCash
            // 
            this.lblPaidCash.AutoSize = true;
            this.lblPaidCash.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidCash.Location = new System.Drawing.Point(123, 330);
            this.lblPaidCash.Name = "lblPaidCash";
            this.lblPaidCash.Size = new System.Drawing.Size(105, 24);
            this.lblPaidCash.TabIndex = 7;
            this.lblPaidCash.Text = "Paid Cash:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(150, 395);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(78, 24);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Change";
            // 
            // tbPaidCash
            // 
            this.tbPaidCash.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaidCash.Location = new System.Drawing.Point(264, 326);
            this.tbPaidCash.Name = "tbPaidCash";
            this.tbPaidCash.Size = new System.Drawing.Size(169, 32);
            this.tbPaidCash.TabIndex = 14;
            this.tbPaidCash.TextChanged += new System.EventHandler(this.tbPaidCash_TextChanged);
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.AutoSize = true;
            this.lblChangeValue.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeValue.Location = new System.Drawing.Point(260, 395);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(21, 24);
            this.lblChangeValue.TabIndex = 7;
            this.lblChangeValue.Text = "0";
            // 
            // FrmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.tsPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPayments";
            this.ShowIcon = false;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.tsPayments.ResumeLayout(false);
            this.tsPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStrip tsPayments;
        private System.Windows.Forms.ErrorProvider epPayments;
        private System.Windows.Forms.TextBox tbAmountToBePaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateAndTime;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPaidCash;
        private System.Windows.Forms.TextBox tbPaidCash;
        private System.Windows.Forms.Label lblChangeValue;
    }
}