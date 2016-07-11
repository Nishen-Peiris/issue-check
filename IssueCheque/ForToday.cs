using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IssueCheque
{
    public partial class ForToday : Form
    {
        public ForToday()
        {
            InitializeComponent();
        }

        string MessageBoxContent;
        string MessageBoxTitle = "Confirm your action.";

        //Loading...

        private void ForToday_Load(object sender, EventArgs e)
        {
            pbCloseM.Visible = false;
            pbMinimizeM.Visible = false;

            //Fade in Effect...

            /* Set Form's Transperancy 100 % */
            this.Opacity = 0;

            /* Start the Timer To Animate Form */
            timFade.Enabled = true;

            //Data Binding...

            string Today = System.DateTime.Now.ToShortDateString();

            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
            string sql = "SELECT ChequeNo, Amount, DOI, DOP, PayableTo FROM tbl_ChequeData WHERE DOP = '" + Today + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tbl_ChequeData");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_ChequeData";

            //GridView Formatting...

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;

            //Configuring Columns of datagridview...

            dataGridView1.Columns[0].HeaderText = "Cheque No";
            dataGridView1.Columns[0].Width = 150;

            dataGridView1.Columns[1].HeaderText = "Amount";
            dataGridView1.Columns[1].Width = 100;

            dataGridView1.Columns[2].HeaderText = "Date of Issue";
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.Columns[3].HeaderText = "Date of Pay";
            dataGridView1.Columns[3].Width = 150;

            dataGridView1.Columns[4].HeaderText = "Payable to";
            dataGridView1.Columns[4].Width = 190;

            //Counting Records...

            if (ds.Tables[0].Rows.Count == 0)
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
            }

            this.ShowInTaskbar = false;
            this.ShowInTaskbar = true;
        }

        //TimFade Tick...

        private void timFade_Tick(object sender, EventArgs e)
        {
            /* Make Form Visible a Bit more on Every timer Tick */
            this.Opacity += 0.01;
        }

        //Minimize Button...

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimizeM.Visible = true;
        }

        private void pbMinimizeM_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizeM.Visible = false;
        }

        private void pbMinimizeM_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Close Button...

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbCloseM.Visible = true;
        }

        private void pbCloseM_MouseLeave(object sender, EventArgs e)
        {
            pbCloseM.Visible = false;
        }

        private void pbCloseM_Click(object sender, EventArgs e)
        {
            MessageBoxContent = "Are you sure you want to exit?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        //View All...    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Close();

            ViewAll nf = new ViewAll();
            nf.Show();
        } 

        //Switch to link...

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            Signin_and_Select_Task nf = new Signin_and_Select_Task();
            nf.Show();
        }
    }
}
