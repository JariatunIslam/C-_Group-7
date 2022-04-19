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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            con.Open();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Accounts_DB;Integrated Security=True");
        void GetList()
        {

            SqlCommand c = new SqlCommand("exec ExpenseList", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            //c.ExecuteNonQuery();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Insert
            string ExpenseID = textBox3.Text;
            DateTime Date = DateTime.Parse(dateTimePicker1.Text);
            string Type = textBox2.Text;
            int amount = int.Parse(textBox4.Text);
            


            SqlCommand c = new SqlCommand("exec InsertExpense'" + ExpenseID + "','" + Date + "','" + Type + "','" + amount +
                "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            MessageBox.Show("Successfully Inserted...");
            GetList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update
            string ExpenseID = textBox3.Text;
            DateTime Date = DateTime.Parse(dateTimePicker1.Text);
            string Type = textBox2.Text;
            int amount = int.Parse(textBox4.Text);



            SqlCommand c = new SqlCommand("exec UpdateExpense'" + ExpenseID + "','" + Date + "','" + Type + "','" + amount +
                "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            MessageBox.Show("Successfully Update...");
            GetList();
        }
    }
}
