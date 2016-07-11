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
    public partial class Issue : Form
    {
        SqlConnection cnn;

        public Issue()
        {
            InitializeComponent();
        }

        //Initializing Variables...

        string RegDate, PayDate, MessageBoxContent;
        string MessageBoxTitle = "Confirm your action.";

        //Loading...

        private void Issue_Load(object sender, EventArgs e)
        {
            pbMinimizeM.Visible = false;
            pbCloseM.Visible = false;

            pbIssue.Visible = false;
            pbIssueM.Visible = false;

            //Fade in Effect...

            /* Set Form's Transperancy 100 % */
            this.Opacity = 0;

            /* Start the Timer To Animate Form */
            timFade.Enabled = true;

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
            MessageBoxContent = "You haven't added any record in this session. Are you sure you want to exit?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        //txtAmount...

        private void mtxtAmount_TextChanged(object sender, EventArgs e)
        {
            if (mtxtAmount.Text == "")
            {
                pbIssue.Visible = false;
            }
            else
            {
                pbIssue.Visible = true;
            }
        }

        private void pbIssue_MouseEnter(object sender, EventArgs e)
        {
            pbIssueM.Visible = true;
        }

        private void pbIssueM_MouseLeave(object sender, EventArgs e)
        {
            pbIssueM.Visible = false;
        }

        private void pbIssueM_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
            string sql = "SELECT * FROM tbl_ChequeData WHERE ChequeNo = '" + txtChequeNo.Text + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tbl_ChequeData");
            connection.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                string MessageBoxContent = "Are you sure you want to save these details?";

                if ((txtChequeNo.Text == "") || (txtPayableTo.Text == ""))
                {
                    MessageBoxContent = "Some fields are empty." + MessageBoxContent;
                }

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Get Date of Registration...

                    RegDate = DateTime.Now.ToShortDateString();

                    //Set Date of Pay...

                    PayDate = dtpDOP.Value.ToShortDateString();

                //Execute Insert...

            tryagain1:
                    try
                    {
                        connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
                        cnn = new SqlConnection(connectionString);

                        cnn.Open();

                        SqlCommand cmd = new SqlCommand("insert into tbl_ChequeData (ChequeNo, Amount, DOI, DOP, PayableTo) values (@ChequeNo, @Amount, @DOI, @DOP, @PayableTo)", cnn);
                        cmd.Parameters.AddWithValue("@ChequeNo", txtChequeNo.Text);
                        cmd.Parameters.AddWithValue("@Amount", mtxtAmount.Text);
                        cmd.Parameters.AddWithValue("@DOI", RegDate);
                        cmd.Parameters.AddWithValue("@DOP", PayDate);
                        cmd.Parameters.AddWithValue("@PayableTo", txtPayableTo.Text);
                        cmd.ExecuteNonQuery();

                        cnn.Close();
                    }
                    catch
                    {
                        goto tryagain1;
                    }

                    //Done...

                    MessageBox.Show("It's now safe to issue the cheque: " + txtChequeNo.Text + "!");

                    Close();

                    Signin_and_Select_Task nf = new Signin_and_Select_Task();
                    nf.Show();                   
                }
                else if (dialogResult == DialogResult.No)
                {
                    txtChequeNo.Text = "";
                    mtxtAmount.Text = "";
                    dtpDOP.Value = System.DateTime.Now;
                    txtChequeNo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("A cheque with cheque number: " + txtChequeNo.Text + "has been already issued. Please verify the cheque number.");
            }
        }

        //Switch to link...

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxContent = "You haven't added any record in this session. Are you sure you want to exit?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();

                Signin_and_Select_Task nf = new Signin_and_Select_Task();
                nf.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
