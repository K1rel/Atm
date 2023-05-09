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
using System.Data.Sql;
using System.Data.SqlClient;

namespace ATMTest2
{
    public partial class fBankAcc : Form
    {
        


        private OleDbConnection connection = new OleDbConnection();
        public fBankAcc()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kire\Documents\My c# projects\ATMTest2\ATMTest2\ATMLogin2.mdb;";
        }

        private void FBankAcc_Load(object sender, EventArgs e)
        {
            


        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO dLogin (Balance) VALUES('"+ txtWithDep.Text + txtBalance.Text + "')";
           command.ExecuteNonQuery();

        }

       

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtWithDep.Text = txtWithDep.Text + button.Text;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            txtWithDep.Clear();
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
