using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IssueCheque
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        //Initializing Variables...

        int y = 0;
        int Rows;

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

        private void about_Load(object sender, EventArgs e)
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

        //timClose Tick...

        private void timClose_Tick(object sender, EventArgs e)
        {
            Close();

            ShowBalloonTip();
        }
    }
}
