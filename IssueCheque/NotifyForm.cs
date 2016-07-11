using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace IssueCheque
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();
        }

        //Initializing Variables...

        int y = 0;
        int Rows;

        //Form Load...

        private void NotifyForm_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;

            timSlide.Enabled = true;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                    Screen.PrimaryScreen.WorkingArea.Height);

            //Any cheque for today...

            string Today = System.DateTime.Now.ToShortDateString();

            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
            string sql = "SELECT ChequeNo, Amount, DOI, DOP, PayableTo FROM tbl_ChequeData WHERE DOP = '" + Today + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tbl_ChequeData");
            connection.Close();


            //Counting Records...

            Rows = ds.Tables[0].Rows.Count;            
        }

        //TimSlide effect...

        private void timSlide_Tick(object sender, EventArgs e)
        {
            if (y == this.Height)
            {
                timSlide.Enabled = false;

                timClose.Enabled = true;
            }
            else
            {
                y = y + 1;

                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                    Screen.PrimaryScreen.WorkingArea.Height - y);
            }            
        }

        //Balloon Tip...

        private void ShowBalloonTip()
        {
            Container bpcomponents = new Container();

            // Initialize menuItem1

            this.ClientSize = new System.Drawing.Size(0, 0);
            this.Text = "Sanuri Steelmart (PVT) LTD.";

            // Create the NotifyIcon.
            NotifyIcon notifyIcon = new NotifyIcon(bpcomponents);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            string iconPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\favicon.ico";
            notifyIcon.Icon = new Icon(iconPath);

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            //notifyIcon.ContextMenu = contextMenu1;

            notifyIcon.Visible = true;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.

            if (Rows == 1)
            {
                notifyIcon.ShowBalloonTip(10000, "Sanuri Steelmart (PVT) LTD!", "There is a cheque to be paid today.", ToolTipIcon.Info);
                //notifyIcon1.ShowBalloonTip(10000, "Sanuri Steelmart (PVT) LTD!", "You have 1 cheque to be paid today. Click this balloon tip for more details.", ToolTipIcon.Info);
                this.Hide();
            }
            else if (Rows > 1)
            {
                notifyIcon.ShowBalloonTip(10000, "Sanuri Steelmart (PVT) LTD!", "There are " + Rows + " cheques to be paid today.", ToolTipIcon.Info);
                //notifyIcon1.ShowBalloonTip(10000, "Sanuri Steelmart (PVT) LTD!", "You have " + Rows + " cheques to be paid today. Click this balloon tip for more details.", ToolTipIcon.Info);
                this.Hide();
            }
            //else
            //{
            //    notifyIcon.ShowBalloonTip(10000, "Sanuri Steelmart (PVT) LTD!", "You have " + Rows + " cheques for today.", ToolTipIcon.Info);
            //    //notifyIcon1.ShowBalloonTip(10000, "Sanuri Steelmart (PVT) LTD!", "You have cheques to be paid today. Click this balloon tip for more details.", ToolTipIcon.Info);
            //    this.Hide();
            //}
        }

        //timClose Tick...

        private void timClose_Tick(object sender, EventArgs e)
        {
            Close();

            ShowBalloonTip();
        }

        //about link...

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            about nf = new about();
            nf.Show();
        }

        //Balloon Tip Clicked...

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            string SignedIn;

            //Check SignedIn Status...

            string connetionStringSignedIn = null;
            SqlConnection connectionSignedIn;
            SqlCommand commandSignedIn;
            SqlDataAdapter adapterSignedIn = new SqlDataAdapter();
            DataSet dsSignedIn = new DataSet();
            string sqlSignedIn = null;

            connetionStringSignedIn = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
            sqlSignedIn = "select ID, SignedIn from tbl_Data";

            connectionSignedIn = new SqlConnection(connetionStringSignedIn);

        tryagainSignedIn:
            try
            {
                connectionSignedIn.Open();
                commandSignedIn = new SqlCommand(sqlSignedIn, connectionSignedIn);
                adapterSignedIn.SelectCommand = commandSignedIn;
                adapterSignedIn.Fill(dsSignedIn);
                adapterSignedIn.Dispose();
                commandSignedIn.Dispose();
                connectionSignedIn.Close();

                listBox1.DataSource = dsSignedIn.Tables[0];
                listBox1.ValueMember = "ID";
                listBox1.DisplayMember = "SignedIn";

            }
            catch
            {
                goto tryagainSignedIn;
            }

            SignedIn = listBox1.Text;

            if (SignedIn == "No")
            {
                MessageBox.Show("Please sign in");
            }
            else
            {
                ForToday nf = new ForToday();
                nf.Show();
            }
        }
    }
}
