namespace POSResturant.Forms
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tsCategories = new System.Windows.Forms.ToolStrip();
            this.epCategories = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkLblSetICategoryImage = new System.Windows.Forms.LinkLabel();
            this.pbCategoryImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tsCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.lnkLblSetICategoryImage);
            this.panel1.Controls.Add(this.tbCategoryName);
            this.panel1.Controls.Add(this.pbCategoryImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 589);
            this.panel1.TabIndex = 6;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoryName.Location = new System.Drawing.Point(278, 133);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(377, 32);
            this.tbCategoryName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(278, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
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
            // tsCategories
            // 
            this.tsCategories.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.tsCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelect,
            this.toolStripSeparator1,
            this.tsbNew,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbFirst,
            this.tsbBack,
            this.tsbNext,
            this.tsbLast});
            this.tsCategories.Location = new System.Drawing.Point(0, 0);
            this.tsCategories.Name = "tsCategories";
            this.tsCategories.Size = new System.Drawing.Size(1062, 121);
            this.tsCategories.TabIndex = 5;
            this.tsCategories.Text = "toolStrip1";
            // 
            // epCategories
            // 
            this.epCategories.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCategories.ContainerControl = this;
            // 
            // lnkLblSetICategoryImage
            // 
            this.lnkLblSetICategoryImage.AutoSize = true;
            this.lnkLblSetICategoryImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblSetICategoryImage.Location = new System.Drawing.Point(799, 379);
            this.lnkLblSetICategoryImage.Name = "lnkLblSetICategoryImage";
            this.lnkLblSetICategoryImage.Size = new System.Drawing.Size(159, 20);
            this.lnkLblSetICategoryImage.TabIndex = 27;
            this.lnkLblSetICategoryImage.TabStop = true;
            this.lnkLblSetICategoryImage.Text = "Set Category Image";
            // 
            // pbCategoryImage
            // 
            this.pbCategoryImage.Image = ((System.Drawing.Image)(resources.GetObject("pbCategoryImage.Image")));
            this.pbCategoryImage.Location = new System.Drawing.Point(793, 133);
            this.pbCategoryImage.Name = "pbCategoryImage";
            this.pbCategoryImage.Size = new System.Drawing.Size(171, 218);
            this.pbCategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategoryImage.TabIndex = 26;
            this.pbCategoryImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(803, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Category Image";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCategories";
            this.ShowIcon = false;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsCategories.ResumeLayout(false);
            this.tsCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStrip tsCategories;
        private System.Windows.Forms.ErrorProvider epCategories;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkLblSetICategoryImage;
        private System.Windows.Forms.PictureBox pbCategoryImage;
        private System.Windows.Forms.Label label2;
    }
}