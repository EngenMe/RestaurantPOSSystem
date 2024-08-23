namespace POSResturant.Forms
{
    partial class FrmPOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOS));
            this.dgvPOS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPaidValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn48 = new System.Windows.Forms.Button();
            this.btn38 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn57 = new System.Windows.Forms.Button();
            this.btn47 = new System.Windows.Forms.Button();
            this.btn37 = new System.Windows.Forms.Button();
            this.btn27 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn56 = new System.Windows.Forms.Button();
            this.btn46 = new System.Windows.Forms.Button();
            this.btn36 = new System.Windows.Forms.Button();
            this.btn26 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn55 = new System.Windows.Forms.Button();
            this.btn54 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn44 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn34 = new System.Windows.Forms.Button();
            this.btn53 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn43 = new System.Windows.Forms.Button();
            this.btn24 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn52 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn42 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.tbn32 = new System.Windows.Forms.Button();
            this.btn51 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn41 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.tbQTY = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.epPOS = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPOS
            // 
            this.dgvPOS.AllowUserToAddRows = false;
            this.dgvPOS.AllowUserToDeleteRows = false;
            this.dgvPOS.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvPOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Item,
            this.QTY,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPOS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.dgvPOS.Location = new System.Drawing.Point(12, 12);
            this.dgvPOS.Name = "dgvPOS";
            this.dgvPOS.ReadOnly = true;
            this.dgvPOS.RowHeadersWidth = 51;
            this.dgvPOS.RowTemplate.Height = 24;
            this.dgvPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPOS.Size = new System.Drawing.Size(462, 633);
            this.dgvPOS.TabIndex = 7;
            this.dgvPOS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPOS_MouseDown);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 58;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 120;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 70;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.BackColor = System.Drawing.Color.Beige;
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.lblTotal);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(12, 651);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(462, 204);
            this.pnlMain.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "€";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(245, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 48);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.cbPayment);
            this.panel1.Controls.Add(this.lblChangeValue);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.lblPaidValue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(480, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 204);
            this.panel1.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(1116, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(229, 80);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(1116, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(229, 80);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(881, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(229, 80);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(646, 111);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(229, 80);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(881, 25);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(229, 80);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.Location = new System.Drawing.Point(646, 25);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(229, 80);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cbPayment
            // 
            this.cbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayment.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(195, 39);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(364, 36);
            this.cbPayment.TabIndex = 1;
            this.cbPayment.SelectedIndexChanged += new System.EventHandler(this.cbPayment_SelectedIndexChanged);
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.AutoSize = true;
            this.lblChangeValue.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblChangeValue.Location = new System.Drawing.Point(188, 139);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(34, 37);
            this.lblChangeValue.TabIndex = 0;
            this.lblChangeValue.Text = "0";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblChange.Location = new System.Drawing.Point(46, 139);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(120, 37);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "Change";
            // 
            // lblPaidValue
            // 
            this.lblPaidValue.AutoSize = true;
            this.lblPaidValue.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.lblPaidValue.Location = new System.Drawing.Point(188, 87);
            this.lblPaidValue.Name = "lblPaidValue";
            this.lblPaidValue.Size = new System.Drawing.Size(34, 37);
            this.lblPaidValue.TabIndex = 0;
            this.lblPaidValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(89, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Payment";
            // 
            // pnlItems
            // 
            this.pnlItems.AutoSize = true;
            this.pnlItems.BackColor = System.Drawing.Color.Beige;
            this.pnlItems.Controls.Add(this.btnBack);
            this.pnlItems.Controls.Add(this.btn48);
            this.pnlItems.Controls.Add(this.btn38);
            this.pnlItems.Controls.Add(this.btn28);
            this.pnlItems.Controls.Add(this.btn18);
            this.pnlItems.Controls.Add(this.btn57);
            this.pnlItems.Controls.Add(this.btn47);
            this.pnlItems.Controls.Add(this.btn37);
            this.pnlItems.Controls.Add(this.btn27);
            this.pnlItems.Controls.Add(this.btn17);
            this.pnlItems.Controls.Add(this.btn56);
            this.pnlItems.Controls.Add(this.btn46);
            this.pnlItems.Controls.Add(this.btn36);
            this.pnlItems.Controls.Add(this.btn26);
            this.pnlItems.Controls.Add(this.btn16);
            this.pnlItems.Controls.Add(this.btn55);
            this.pnlItems.Controls.Add(this.btn54);
            this.pnlItems.Controls.Add(this.btn45);
            this.pnlItems.Controls.Add(this.btn44);
            this.pnlItems.Controls.Add(this.btn35);
            this.pnlItems.Controls.Add(this.btn34);
            this.pnlItems.Controls.Add(this.btn53);
            this.pnlItems.Controls.Add(this.btn25);
            this.pnlItems.Controls.Add(this.btn43);
            this.pnlItems.Controls.Add(this.btn24);
            this.pnlItems.Controls.Add(this.btn33);
            this.pnlItems.Controls.Add(this.btn52);
            this.pnlItems.Controls.Add(this.btn15);
            this.pnlItems.Controls.Add(this.btn42);
            this.pnlItems.Controls.Add(this.btn23);
            this.pnlItems.Controls.Add(this.tbn32);
            this.pnlItems.Controls.Add(this.btn51);
            this.pnlItems.Controls.Add(this.btn14);
            this.pnlItems.Controls.Add(this.btn41);
            this.pnlItems.Controls.Add(this.btn22);
            this.pnlItems.Controls.Add(this.btn31);
            this.pnlItems.Controls.Add(this.btn13);
            this.pnlItems.Controls.Add(this.btn21);
            this.pnlItems.Controls.Add(this.btn12);
            this.pnlItems.Controls.Add(this.btn11);
            this.pnlItems.Location = new System.Drawing.Point(480, 12);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(10);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1032, 633);
            this.pnlItems.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.Location = new System.Drawing.Point(897, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 120);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn48
            // 
            this.btn48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn48.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn48.Image = ((System.Drawing.Image)(resources.GetObject("btn48.Image")));
            this.btn48.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn48.Location = new System.Drawing.Point(897, 379);
            this.btn48.Name = "btn48";
            this.btn48.Size = new System.Drawing.Size(120, 120);
            this.btn48.TabIndex = 32;
            this.btn48.Text = "text";
            this.btn48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn48.UseVisualStyleBackColor = true;
            this.btn48.Visible = false;
            this.btn48.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn38
            // 
            this.btn38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn38.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn38.Image = ((System.Drawing.Image)(resources.GetObject("btn38.Image")));
            this.btn38.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn38.Location = new System.Drawing.Point(897, 253);
            this.btn38.Name = "btn38";
            this.btn38.Size = new System.Drawing.Size(120, 120);
            this.btn38.TabIndex = 24;
            this.btn38.Text = "text";
            this.btn38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn38.UseVisualStyleBackColor = true;
            this.btn38.Visible = false;
            this.btn38.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn28
            // 
            this.btn28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn28.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn28.Image = ((System.Drawing.Image)(resources.GetObject("btn28.Image")));
            this.btn28.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn28.Location = new System.Drawing.Point(897, 127);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(120, 120);
            this.btn28.TabIndex = 16;
            this.btn28.Text = "text";
            this.btn28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn28.UseVisualStyleBackColor = true;
            this.btn28.Visible = false;
            this.btn28.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn18
            // 
            this.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn18.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn18.Image = ((System.Drawing.Image)(resources.GetObject("btn18.Image")));
            this.btn18.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn18.Location = new System.Drawing.Point(897, 3);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(120, 120);
            this.btn18.TabIndex = 8;
            this.btn18.Text = "text";
            this.btn18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn18.UseVisualStyleBackColor = true;
            this.btn18.Visible = false;
            this.btn18.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn57
            // 
            this.btn57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn57.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn57.Image = ((System.Drawing.Image)(resources.GetObject("btn57.Image")));
            this.btn57.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn57.Location = new System.Drawing.Point(771, 505);
            this.btn57.Name = "btn57";
            this.btn57.Size = new System.Drawing.Size(120, 120);
            this.btn57.TabIndex = 39;
            this.btn57.Text = "text";
            this.btn57.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn57.UseVisualStyleBackColor = true;
            this.btn57.Visible = false;
            this.btn57.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn47
            // 
            this.btn47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn47.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn47.Image = ((System.Drawing.Image)(resources.GetObject("btn47.Image")));
            this.btn47.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn47.Location = new System.Drawing.Point(771, 379);
            this.btn47.Name = "btn47";
            this.btn47.Size = new System.Drawing.Size(120, 120);
            this.btn47.TabIndex = 31;
            this.btn47.Text = "text";
            this.btn47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn47.UseVisualStyleBackColor = true;
            this.btn47.Visible = false;
            this.btn47.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn37
            // 
            this.btn37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn37.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn37.Image = ((System.Drawing.Image)(resources.GetObject("btn37.Image")));
            this.btn37.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn37.Location = new System.Drawing.Point(771, 253);
            this.btn37.Name = "btn37";
            this.btn37.Size = new System.Drawing.Size(120, 120);
            this.btn37.TabIndex = 23;
            this.btn37.Text = "text";
            this.btn37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn37.UseVisualStyleBackColor = true;
            this.btn37.Visible = false;
            this.btn37.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn27
            // 
            this.btn27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn27.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn27.Image = ((System.Drawing.Image)(resources.GetObject("btn27.Image")));
            this.btn27.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn27.Location = new System.Drawing.Point(771, 127);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(120, 120);
            this.btn27.TabIndex = 15;
            this.btn27.Text = "text";
            this.btn27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn27.UseVisualStyleBackColor = true;
            this.btn27.Visible = false;
            this.btn27.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn17
            // 
            this.btn17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn17.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn17.Image = ((System.Drawing.Image)(resources.GetObject("btn17.Image")));
            this.btn17.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn17.Location = new System.Drawing.Point(771, 3);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(120, 120);
            this.btn17.TabIndex = 7;
            this.btn17.Text = "text";
            this.btn17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn17.UseVisualStyleBackColor = true;
            this.btn17.Visible = false;
            this.btn17.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn56
            // 
            this.btn56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn56.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn56.Image = ((System.Drawing.Image)(resources.GetObject("btn56.Image")));
            this.btn56.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn56.Location = new System.Drawing.Point(645, 505);
            this.btn56.Name = "btn56";
            this.btn56.Size = new System.Drawing.Size(120, 120);
            this.btn56.TabIndex = 38;
            this.btn56.Text = "text";
            this.btn56.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn56.UseVisualStyleBackColor = true;
            this.btn56.Visible = false;
            this.btn56.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn46
            // 
            this.btn46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn46.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn46.Image = ((System.Drawing.Image)(resources.GetObject("btn46.Image")));
            this.btn46.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn46.Location = new System.Drawing.Point(645, 379);
            this.btn46.Name = "btn46";
            this.btn46.Size = new System.Drawing.Size(120, 120);
            this.btn46.TabIndex = 30;
            this.btn46.Text = "text";
            this.btn46.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn46.UseVisualStyleBackColor = true;
            this.btn46.Visible = false;
            this.btn46.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn36
            // 
            this.btn36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn36.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn36.Image = ((System.Drawing.Image)(resources.GetObject("btn36.Image")));
            this.btn36.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn36.Location = new System.Drawing.Point(645, 253);
            this.btn36.Name = "btn36";
            this.btn36.Size = new System.Drawing.Size(120, 120);
            this.btn36.TabIndex = 22;
            this.btn36.Text = "text";
            this.btn36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn36.UseVisualStyleBackColor = true;
            this.btn36.Visible = false;
            this.btn36.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn26
            // 
            this.btn26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn26.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn26.Image = ((System.Drawing.Image)(resources.GetObject("btn26.Image")));
            this.btn26.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn26.Location = new System.Drawing.Point(645, 127);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(120, 120);
            this.btn26.TabIndex = 14;
            this.btn26.Text = "text";
            this.btn26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn26.UseVisualStyleBackColor = true;
            this.btn26.Visible = false;
            this.btn26.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn16
            // 
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16.Image = ((System.Drawing.Image)(resources.GetObject("btn16.Image")));
            this.btn16.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn16.Location = new System.Drawing.Point(645, 3);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(120, 120);
            this.btn16.TabIndex = 6;
            this.btn16.Text = "text";
            this.btn16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Visible = false;
            this.btn16.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn55
            // 
            this.btn55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn55.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn55.Image = ((System.Drawing.Image)(resources.GetObject("btn55.Image")));
            this.btn55.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn55.Location = new System.Drawing.Point(519, 505);
            this.btn55.Name = "btn55";
            this.btn55.Size = new System.Drawing.Size(120, 120);
            this.btn55.TabIndex = 37;
            this.btn55.Text = "text";
            this.btn55.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn55.UseVisualStyleBackColor = true;
            this.btn55.Visible = false;
            this.btn55.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn54
            // 
            this.btn54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn54.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn54.Image = ((System.Drawing.Image)(resources.GetObject("btn54.Image")));
            this.btn54.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn54.Location = new System.Drawing.Point(393, 505);
            this.btn54.Name = "btn54";
            this.btn54.Size = new System.Drawing.Size(120, 120);
            this.btn54.TabIndex = 36;
            this.btn54.Text = "text";
            this.btn54.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn54.UseVisualStyleBackColor = true;
            this.btn54.Visible = false;
            this.btn54.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn45
            // 
            this.btn45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn45.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn45.Image = ((System.Drawing.Image)(resources.GetObject("btn45.Image")));
            this.btn45.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn45.Location = new System.Drawing.Point(519, 379);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(120, 120);
            this.btn45.TabIndex = 29;
            this.btn45.Text = "text";
            this.btn45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Visible = false;
            this.btn45.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn44
            // 
            this.btn44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn44.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn44.Image = ((System.Drawing.Image)(resources.GetObject("btn44.Image")));
            this.btn44.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn44.Location = new System.Drawing.Point(393, 379);
            this.btn44.Name = "btn44";
            this.btn44.Size = new System.Drawing.Size(120, 120);
            this.btn44.TabIndex = 28;
            this.btn44.Text = "text";
            this.btn44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn44.UseVisualStyleBackColor = true;
            this.btn44.Visible = false;
            this.btn44.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn35
            // 
            this.btn35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn35.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn35.Image = ((System.Drawing.Image)(resources.GetObject("btn35.Image")));
            this.btn35.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn35.Location = new System.Drawing.Point(519, 253);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(120, 120);
            this.btn35.TabIndex = 21;
            this.btn35.Text = "text";
            this.btn35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn35.UseVisualStyleBackColor = true;
            this.btn35.Visible = false;
            this.btn35.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn34
            // 
            this.btn34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn34.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn34.Image = ((System.Drawing.Image)(resources.GetObject("btn34.Image")));
            this.btn34.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn34.Location = new System.Drawing.Point(393, 253);
            this.btn34.Name = "btn34";
            this.btn34.Size = new System.Drawing.Size(120, 120);
            this.btn34.TabIndex = 20;
            this.btn34.Text = "text";
            this.btn34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn34.UseVisualStyleBackColor = true;
            this.btn34.Visible = false;
            this.btn34.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn53
            // 
            this.btn53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn53.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn53.Image = ((System.Drawing.Image)(resources.GetObject("btn53.Image")));
            this.btn53.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn53.Location = new System.Drawing.Point(267, 505);
            this.btn53.Name = "btn53";
            this.btn53.Size = new System.Drawing.Size(120, 120);
            this.btn53.TabIndex = 35;
            this.btn53.Text = "text";
            this.btn53.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn53.UseVisualStyleBackColor = true;
            this.btn53.Visible = false;
            this.btn53.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn25
            // 
            this.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn25.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.Image = ((System.Drawing.Image)(resources.GetObject("btn25.Image")));
            this.btn25.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn25.Location = new System.Drawing.Point(519, 127);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(120, 120);
            this.btn25.TabIndex = 13;
            this.btn25.Text = "text";
            this.btn25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Visible = false;
            this.btn25.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn43
            // 
            this.btn43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn43.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn43.Image = ((System.Drawing.Image)(resources.GetObject("btn43.Image")));
            this.btn43.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn43.Location = new System.Drawing.Point(267, 379);
            this.btn43.Name = "btn43";
            this.btn43.Size = new System.Drawing.Size(120, 120);
            this.btn43.TabIndex = 27;
            this.btn43.Text = "text";
            this.btn43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn43.UseVisualStyleBackColor = true;
            this.btn43.Visible = false;
            this.btn43.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn24
            // 
            this.btn24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn24.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn24.Image = ((System.Drawing.Image)(resources.GetObject("btn24.Image")));
            this.btn24.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn24.Location = new System.Drawing.Point(393, 127);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(120, 120);
            this.btn24.TabIndex = 12;
            this.btn24.Text = "text";
            this.btn24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn24.UseVisualStyleBackColor = true;
            this.btn24.Visible = false;
            this.btn24.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn33
            // 
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Image = ((System.Drawing.Image)(resources.GetObject("btn33.Image")));
            this.btn33.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn33.Location = new System.Drawing.Point(267, 253);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(120, 120);
            this.btn33.TabIndex = 19;
            this.btn33.Text = "text";
            this.btn33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Visible = false;
            this.btn33.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn52
            // 
            this.btn52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn52.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn52.Image = ((System.Drawing.Image)(resources.GetObject("btn52.Image")));
            this.btn52.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn52.Location = new System.Drawing.Point(141, 505);
            this.btn52.Name = "btn52";
            this.btn52.Size = new System.Drawing.Size(120, 120);
            this.btn52.TabIndex = 34;
            this.btn52.Text = "text";
            this.btn52.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn52.UseVisualStyleBackColor = true;
            this.btn52.Visible = false;
            this.btn52.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn15
            // 
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Image = ((System.Drawing.Image)(resources.GetObject("btn15.Image")));
            this.btn15.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn15.Location = new System.Drawing.Point(519, 3);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(120, 120);
            this.btn15.TabIndex = 5;
            this.btn15.Text = "text";
            this.btn15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Visible = false;
            this.btn15.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn42
            // 
            this.btn42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn42.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn42.Image = ((System.Drawing.Image)(resources.GetObject("btn42.Image")));
            this.btn42.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn42.Location = new System.Drawing.Point(141, 379);
            this.btn42.Name = "btn42";
            this.btn42.Size = new System.Drawing.Size(120, 120);
            this.btn42.TabIndex = 26;
            this.btn42.Text = "text";
            this.btn42.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn42.UseVisualStyleBackColor = true;
            this.btn42.Visible = false;
            this.btn42.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn23
            // 
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Image = ((System.Drawing.Image)(resources.GetObject("btn23.Image")));
            this.btn23.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn23.Location = new System.Drawing.Point(267, 127);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(120, 120);
            this.btn23.TabIndex = 11;
            this.btn23.Text = "text";
            this.btn23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Visible = false;
            this.btn23.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // tbn32
            // 
            this.tbn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn32.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn32.Image = ((System.Drawing.Image)(resources.GetObject("tbn32.Image")));
            this.tbn32.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbn32.Location = new System.Drawing.Point(141, 253);
            this.tbn32.Name = "tbn32";
            this.tbn32.Size = new System.Drawing.Size(120, 120);
            this.tbn32.TabIndex = 18;
            this.tbn32.Text = "text";
            this.tbn32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tbn32.UseVisualStyleBackColor = true;
            this.tbn32.Visible = false;
            this.tbn32.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn51
            // 
            this.btn51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn51.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn51.Image = ((System.Drawing.Image)(resources.GetObject("btn51.Image")));
            this.btn51.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn51.Location = new System.Drawing.Point(15, 505);
            this.btn51.Name = "btn51";
            this.btn51.Size = new System.Drawing.Size(120, 120);
            this.btn51.TabIndex = 33;
            this.btn51.Text = "text";
            this.btn51.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn51.UseVisualStyleBackColor = true;
            this.btn51.Visible = false;
            this.btn51.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn14
            // 
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Image = ((System.Drawing.Image)(resources.GetObject("btn14.Image")));
            this.btn14.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn14.Location = new System.Drawing.Point(393, 3);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(120, 120);
            this.btn14.TabIndex = 4;
            this.btn14.Text = "text";
            this.btn14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Visible = false;
            this.btn14.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn41
            // 
            this.btn41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn41.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn41.Image = ((System.Drawing.Image)(resources.GetObject("btn41.Image")));
            this.btn41.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn41.Location = new System.Drawing.Point(15, 379);
            this.btn41.Name = "btn41";
            this.btn41.Size = new System.Drawing.Size(120, 120);
            this.btn41.TabIndex = 25;
            this.btn41.Text = "text";
            this.btn41.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn41.UseVisualStyleBackColor = true;
            this.btn41.Visible = false;
            this.btn41.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn22
            // 
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Image = ((System.Drawing.Image)(resources.GetObject("btn22.Image")));
            this.btn22.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn22.Location = new System.Drawing.Point(141, 127);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(120, 120);
            this.btn22.TabIndex = 10;
            this.btn22.Text = "text";
            this.btn22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Visible = false;
            this.btn22.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn31
            // 
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Image = ((System.Drawing.Image)(resources.GetObject("btn31.Image")));
            this.btn31.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn31.Location = new System.Drawing.Point(15, 253);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(120, 120);
            this.btn31.TabIndex = 17;
            this.btn31.Text = "text";
            this.btn31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Visible = false;
            this.btn31.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn13
            // 
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Image = ((System.Drawing.Image)(resources.GetObject("btn13.Image")));
            this.btn13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn13.Location = new System.Drawing.Point(267, 3);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(120, 120);
            this.btn13.TabIndex = 3;
            this.btn13.Text = "text";
            this.btn13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Visible = false;
            this.btn13.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn21
            // 
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Image = ((System.Drawing.Image)(resources.GetObject("btn21.Image")));
            this.btn21.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn21.Location = new System.Drawing.Point(15, 127);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(120, 120);
            this.btn21.TabIndex = 9;
            this.btn21.Text = "text";
            this.btn21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Visible = false;
            this.btn21.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn12
            // 
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Image = ((System.Drawing.Image)(resources.GetObject("btn12.Image")));
            this.btn12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn12.Location = new System.Drawing.Point(141, 3);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(120, 120);
            this.btn12.TabIndex = 2;
            this.btn12.Text = "text";
            this.btn12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Visible = false;
            this.btn12.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // btn11
            // 
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Image = ((System.Drawing.Image)(resources.GetObject("btn11.Image")));
            this.btn11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn11.Location = new System.Drawing.Point(15, 3);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(120, 120);
            this.btn11.TabIndex = 1;
            this.btn11.Text = "text";
            this.btn11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Visible = false;
            this.btn11.Click += new System.EventHandler(this.BtnCategory_Clicked);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.Controls.Add(this.btnC);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Controls.Add(this.btn00);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.tbQTY);
            this.panel3.Controls.Add(this.btn0);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Location = new System.Drawing.Point(1518, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 633);
            this.panel3.TabIndex = 8;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(250, 512);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(90, 90);
            this.btnC.TabIndex = 0;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(250, 352);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 90);
            this.btn3.TabIndex = 0;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(250, 239);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 90);
            this.btn6.TabIndex = 0;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(250, 126);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 90);
            this.btn9.TabIndex = 0;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(134, 512);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(90, 90);
            this.btn00.TabIndex = 0;
            this.btn00.Tag = "00";
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(134, 352);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 90);
            this.btn2.TabIndex = 0;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(134, 239);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 90);
            this.btn5.TabIndex = 0;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // tbQTY
            // 
            this.tbQTY.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQTY.Location = new System.Drawing.Point(18, 38);
            this.tbQTY.Name = "tbQTY";
            this.tbQTY.Size = new System.Drawing.Size(322, 44);
            this.tbQTY.TabIndex = 2;
            this.tbQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(18, 512);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 90);
            this.btn0.TabIndex = 0;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(134, 126);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 90);
            this.btn8.TabIndex = 0;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(18, 352);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 90);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(18, 239);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 90);
            this.btn4.TabIndex = 0;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(18, 126);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 90);
            this.btn7.TabIndex = 0;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnNumbClicked);
            // 
            // epPOS
            // 
            this.epPOS.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPOS.ContainerControl = this;
            // 
            // FrmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1888, 867);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.dgvPOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.Load += new System.EventHandler(this.FrmPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlItems.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPOS;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.TextBox tbQTY;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btn48;
        private System.Windows.Forms.Button btn38;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn57;
        private System.Windows.Forms.Button btn47;
        private System.Windows.Forms.Button btn37;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn56;
        private System.Windows.Forms.Button btn46;
        private System.Windows.Forms.Button btn36;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn55;
        private System.Windows.Forms.Button btn54;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn44;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn34;
        private System.Windows.Forms.Button btn53;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn43;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn52;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn42;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button tbn32;
        private System.Windows.Forms.Button btn51;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn41;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ErrorProvider epPOS;
        private System.Windows.Forms.Label lblChangeValue;
        private System.Windows.Forms.Label lblPaidValue;
    }
}