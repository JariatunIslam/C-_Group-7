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
    public partial class Employee_List : Form
    {
        public Employee_List()
        {
            InitializeComponent();
            con.Open();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Accounts_DB;Integrated Security=True");
        
        private void button2_Click(object sender, EventArgs e)
        {

        }
        void GetListEmp()
        {
            
            SqlCommand c = new SqlCommand("exec EmpList", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            
            
        }
    

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            GetListEmp();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //delete
            if (MessageBox.Show("Are you sure?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string userId = textBox3.Text;
                SqlCommand c = new SqlCommand("exec DeleteEmp '" + userId + "'", con);

                c.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted...");

                GetListEmp();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update
           
            string userId = textBox3.Text;
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            DateTime DOB = DateTime.Parse(dateTimePicker1.Text);
            string gender = "";
            string email = textBox4.Text;
            int mobile = int.Parse(textBox5.Text);
            string address = textBox6.Text;
            DateTime JD = DateTime.Parse(dateTimePicker2.Text);
          
            if (radioButton1.Checked == true) { gender = "Male"; }
            else if (radioButton2.Checked == true) { gender = "Female"; }
            else { gender = "Other"; }

          
            SqlCommand c = new SqlCommand("exec UpdateEmpInfo '" + userId + "','" + firstName + "','" + lastName + "','" + DOB + "','" + gender +
                "','" + email + "','" + mobile + "','" + address + "', '" + JD + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           
            MessageBox.Show("Successfully Updated...");

            GetListEmp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search 
            string userId = textBox3.Text;
            SqlCommand c = new SqlCommand("exec SearchEmp '" + userId + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
