using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccountsManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
      
     
        SqlConnection link = new SqlConnection("Data Source=.;Initial Catalog=Accounts_DB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string query= "Select User_Id,Password from Registration where User_Id='"+ textBox1.Text.Trim()+ "'and password='"+ textBox2.Text.Trim()+ "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, link);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Dashboard dash1 = new Dashboard(textBox1.Text.Trim());
                this.Hide();
                dash1.Show();


            }
            else { MessageBox.Show("Check Username and password"); }
            
            
           
            
            


        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 rg = new Form1();
            this.Hide();
            rg.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
