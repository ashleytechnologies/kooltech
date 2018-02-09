using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Location = new Point(0, 0);
        }

        private void btnCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void barcodePrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarcode fb = new frmBarcode();
            fb.ShowDialog();
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStock fs = new frmStock();
            fs.ShowDialog();
        }

        public static void dataInsertion()
        {
           // int CusId = Convert.ToInt32(txtCustomerCode.Text);
           // string CusName = txtCustomerCode.Text;
            string CusAddress;
            string CusEmail;
            string CusMobile;
            string CusNic;
            string CusWorkPlace;
            string CusWorkAddress;
            string CusWorkPhone;
            float CusCreditLimit;
            int CusJobId;
            int CusDesignationId;
            Boolean Active;

            SqlConnection con = connection.OpenConnection();

            SqlCommand cmd = new SqlCommand();
          //  cmd.CommandType = CommandType.Text;
           // cmd.CommandText = "INSERT INTO [dbo].[TblCustomer] ([CusId] ,[CusName] ,[CusAddress] ,[CusEmail] ,[CusMobile] ,[CusNic] ,[CusWorkPlace] ,[CusWorkAddress] ,[CusWorkPhone] ,[CusCreditLimit] ,[CusJobId] ,[CusDesignationId] ,[Active]) VALUES (@CusId ,@CusName ,@CusAddress ,@CusEmail ,@CusMobile ,@CusNic ,@CusWorkPlace ,@CusWorkAddress ,@CusWorkPhone ,@CusCreditLimit ,@CusJobId ,@CusDesignationId ,@Active)";
            //cmd.Parameters.AddWithValue("@CustomerCode", );
            //cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void _TextChanged(object sender, EventArgs e)
        {

        }
    }
}
