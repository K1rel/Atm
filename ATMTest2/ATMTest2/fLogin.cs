using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ATMTest2
{
    public partial class frmLogin : Form
    {
        public static string passingText;
        private OleDbConnection connection = new OleDbConnection();
        public frmLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kire\Documents\My c# projects\ATMTest2\ATMTest2\ATMLogin2.mdb;";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            passingText = txtUsername.Text;
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * from dLogin WHERE Username = '"+txtUsername.Text+"' AND Password = '"+txtPassword.Text+"'";
           OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                // count++;
                //
            }
            if(count ==1)
            {
                MessageBox.Show("Welcome, " + txtUsername.Text);
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form f2 = new fBankAcc();
                f2.ShowDialog();
                

            }
           else if (count > 1)
            {
                MessageBox.Show("Duplicate username and password");
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }

             connection.Close();
        }
    }
}
