namespace IssueCheque
{
    partial class ForToday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForToday));
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbCloseM = new System.Windows.Forms.PictureBox();
            this.pbMinimizeM = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblChequeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new IssueCheque.Database1DataSet1();
            this.tbl_ChequeDataTableAdapter = new IssueCheque.Database1DataSet1TableAdapters.tbl_ChequeDataTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timFade = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChequeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbBackground.Image")));
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(980, 650);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            this.pbBackground.Visible = false;
            // 
            // pbCloseM
            // 
            this.pbCloseM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseM.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseM.Image")));
            this.pbCloseM.Location = new System.Drawing.Point(929, 8);
            this.pbCloseM.Name = "pbCloseM";
            this.pbCloseM.Size = new System.Drawing.Size(40, 25);
            this.pbCloseM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCloseM.TabIndex = 31;
            this.pbCloseM.TabStop = false;
            this.pbCloseM.MouseLeave += new System.EventHandler(this.pbCloseM_MouseLeave);
            this.pbCloseM.Click += new System.EventHandler(this.pbCloseM_Click);
            // 
            // pbMinimizeM
            // 
            this.pbMinimizeM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizeM.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizeM.Image")));
            this.pbMinimizeM.Location = new System.Drawing.Point(891, 8);
            this.pbMinimizeM.Name = "pbMinimizeM";
            this.pbMinimizeM.Size = new System.Drawing.Size(40, 25);
            this.pbMinimizeM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimizeM.TabIndex = 30;
            this.pbMinimizeM.TabStop = false;
            this.pbMinimizeM.MouseLeave += new System.EventHandler(this.pbMinimizeM_MouseLeave);
            this.pbMinimizeM.Click += new System.EventHandler(this.pbMinimizeM_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(929, 8);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 33;
            this.pbClose.TabStop = false;
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(891, 8);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(40, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimize.TabIndex = 32;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(790, 290);
            this.dataGridView1.TabIndex = 36;
            this.toolTip1.SetToolTip(this.dataGridView1, "Cheques for today.");
            // 
            // tblChequeDataBindingSource
            // 
            this.tblChequeDataBindingSource.DataMember = "tbl_ChequeData";
            this.tblChequeDataBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ChequeDataTableAdapter
            // 
            this.tbl_ChequeDataTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 496);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(65, 555);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 40;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Switch to";
            this.toolTip1.SetToolTip(this.linkLabel1, "Click here to go to the Switch Task Pafe.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timFade
            // 
            this.timFade.Interval = 10;
            this.timFade.Tick += new System.EventHandler(this.timFade_Tick);
            // 
            // ForToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbCloseM);
            this.Controls.Add(this.pbMinimizeM);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForToday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanuri Steelmart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ForToday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChequeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbCloseM;
        private System.Windows.Forms.PictureBox pbMinimizeM;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource tblChequeDataBindingSource;
        private IssueCheque.Database1DataSet1TableAdapters.tbl_ChequeDataTableAdapter tbl_ChequeDataTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timFade;
    }
}