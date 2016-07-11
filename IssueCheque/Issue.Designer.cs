namespace IssueCheque
{
    partial class Issue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue));
            this.pbCloseM = new System.Windows.Forms.PictureBox();
            this.pbMinimizeM = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbIssueM = new System.Windows.Forms.PictureBox();
            this.pbIssue = new System.Windows.Forms.PictureBox();
            this.dtpDOP = new System.Windows.Forms.DateTimePicker();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.txtPayableTo = new System.Windows.Forms.TextBox();
            this.mtxtAmount = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timFade = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIssueM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCloseM
            // 
            this.pbCloseM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseM.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseM.Image")));
            this.pbCloseM.Location = new System.Drawing.Point(927, 8);
            this.pbCloseM.Name = "pbCloseM";
            this.pbCloseM.Size = new System.Drawing.Size(40, 25);
            this.pbCloseM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCloseM.TabIndex = 14;
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
            this.pbMinimizeM.TabIndex = 13;
            this.pbMinimizeM.TabStop = false;
            this.pbMinimizeM.MouseLeave += new System.EventHandler(this.pbMinimizeM_MouseLeave);
            this.pbMinimizeM.Click += new System.EventHandler(this.pbMinimizeM_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(927, 8);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 16;
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
            this.pbMinimize.TabIndex = 15;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            // 
            // pbIssueM
            // 
            this.pbIssueM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIssueM.Image = ((System.Drawing.Image)(resources.GetObject("pbIssueM.Image")));
            this.pbIssueM.Location = new System.Drawing.Point(768, 536);
            this.pbIssueM.Name = "pbIssueM";
            this.pbIssueM.Size = new System.Drawing.Size(140, 40);
            this.pbIssueM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIssueM.TabIndex = 18;
            this.pbIssueM.TabStop = false;
            this.toolTip1.SetToolTip(this.pbIssueM, "Enter the details & Click here or Press Enter to send data to the database.");
            this.pbIssueM.MouseLeave += new System.EventHandler(this.pbIssueM_MouseLeave);
            this.pbIssueM.Click += new System.EventHandler(this.pbIssueM_Click);
            // 
            // pbIssue
            // 
            this.pbIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIssue.Image = ((System.Drawing.Image)(resources.GetObject("pbIssue.Image")));
            this.pbIssue.Location = new System.Drawing.Point(768, 536);
            this.pbIssue.Name = "pbIssue";
            this.pbIssue.Size = new System.Drawing.Size(140, 40);
            this.pbIssue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIssue.TabIndex = 17;
            this.pbIssue.TabStop = false;
            this.pbIssue.MouseEnter += new System.EventHandler(this.pbIssue_MouseEnter);
            // 
            // dtpDOP
            // 
            this.dtpDOP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOP.Location = new System.Drawing.Point(350, 263);
            this.dtpDOP.Name = "dtpDOP";
            this.dtpDOP.Size = new System.Drawing.Size(200, 20);
            this.dtpDOP.TabIndex = 3;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(350, 190);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(200, 20);
            this.txtChequeNo.TabIndex = 1;
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbBackground.Image")));
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(980, 650);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 22;
            this.pbBackground.TabStop = false;
            // 
            // txtPayableTo
            // 
            this.txtPayableTo.Location = new System.Drawing.Point(350, 299);
            this.txtPayableTo.Name = "txtPayableTo";
            this.txtPayableTo.Size = new System.Drawing.Size(200, 20);
            this.txtPayableTo.TabIndex = 4;
            // 
            // mtxtAmount
            // 
            this.mtxtAmount.Location = new System.Drawing.Point(350, 226);
            this.mtxtAmount.Mask = "00000000";
            this.mtxtAmount.Name = "mtxtAmount";
            this.mtxtAmount.Size = new System.Drawing.Size(200, 20);
            this.mtxtAmount.TabIndex = 2;
            this.mtxtAmount.TextChanged += new System.EventHandler(this.mtxtAmount_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(65, 555);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 26;
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
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.mtxtAmount);
            this.Controls.Add(this.txtPayableTo);
            this.Controls.Add(this.dtpDOP);
            this.Controls.Add(this.txtChequeNo);
            this.Controls.Add(this.pbIssueM);
            this.Controls.Add(this.pbIssue);
            this.Controls.Add(this.pbCloseM);
            this.Controls.Add(this.pbMinimizeM);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanuri Steelmart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIssueM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCloseM;
        private System.Windows.Forms.PictureBox pbMinimizeM;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbIssueM;
        private System.Windows.Forms.PictureBox pbIssue;
        private System.Windows.Forms.DateTimePicker dtpDOP;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.TextBox txtPayableTo;
        private System.Windows.Forms.MaskedTextBox mtxtAmount;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timFade;
    }
}