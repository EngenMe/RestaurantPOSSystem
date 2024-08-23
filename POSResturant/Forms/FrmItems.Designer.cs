namespace POSResturant.Forms
{
    partial class FrmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItems));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lnkLblSetItemImage = new System.Windows.Forms.LinkLabel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.tsItems = new System.Windows.Forms.ToolStrip();
            this.epItems = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.tsItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Beige;
            this.pnlControls.Controls.Add(this.cbCategory);
            this.pnlControls.Controls.Add(this.lnkLblSetItemImage);
            this.pnlControls.Controls.Add(this.tbDescription);
            this.pnlControls.Controls.Add(this.tbPrice);
            this.pnlControls.Controls.Add(this.tbName);
            this.pnlControls.Controls.Add(this.pbItemImage);
            this.pnlControls.Controls.Add(this.label9);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.lblID);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 121);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1062, 589);
            this.pnlControls.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(194, 414);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(344, 32);
            this.cbCategory.TabIndex = 25;
            // 
            // lnkLblSetItemImage
            // 
            this.lnkLblSetItemImage.AutoSize = true;
            this.lnkLblSetItemImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblSetItemImage.Location = new System.Drawing.Point(819, 347);
            this.lnkLblSetItemImage.Name = "lnkLblSetItemImage";
            this.lnkLblSetItemImage.Size = new System.Drawing.Size(125, 20);
            this.lnkLblSetItemImage.TabIndex = 24;
            this.lnkLblSetItemImage.TabStop = true;
            this.lnkLblSetItemImage.Text = "Set Item Image";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(194, 227);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(344, 140);
            this.tbDescription.TabIndex = 21;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(194, 167);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(181, 32);
            this.tbPrice.TabIndex = 20;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(194, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(344, 32);
            this.tbName.TabIndex = 18;
            // 
            // pbItemImage
            // 
            this.pbItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbItemImage.Image")));
            this.pbItemImage.Location = new System.Drawing.Point(796, 101);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(171, 218);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 19;
            this.pbItemImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(825, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(190, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 24);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
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
            // tsItems
            // 
            this.tsItems.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.tsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelect,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbFirst,
            this.tsbBack,
            this.tsbNext,
            this.tsbLast});
            this.tsItems.Location = new System.Drawing.Point(0, 0);
            this.tsItems.Name = "tsItems";
            this.tsItems.Size = new System.Drawing.Size(1062, 121);
            this.tsItems.TabIndex = 5;
            this.tsItems.Text = "toolStrip1";
            // 
            // epItems
            // 
            this.epItems.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epItems.ContainerControl = this;
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.tsItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmItems";
            this.ShowIcon = false;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.tsItems.ResumeLayout(false);
            this.tsItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epItems)).EndInit();
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
        private System.Windows.Forms.ToolStrip tsItems;
        private System.Windows.Forms.ErrorProvider epItems;
        private System.Windows.Forms.LinkLabel lnkLblSetItemImage;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}