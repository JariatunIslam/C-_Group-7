using System.Data;
using System.Data.SqlClient;

namespace AccountsManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Accounts_DB;Integrated Security=True");

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string userId=textBox3.Text;
            string firstName=textBox1.Text;
            string lastName=textBox2.Text;
            DateTime DOB = DateTime.Parse(dateTimePicker1.Text);
            string gender="";
            string email=textBox4.Text;
            int mobile = int.Parse(textBox5.Text);
            string address=textBox6.Text;
            DateTime JD = DateTime.Parse(dateTimePicker2.Text);
            string Pass =textBox7.Text;
            if (radioButton1.Checked == true) { gender = "Male"; } 
            else if (radioButton2.Checked == true) { gender = "Female"; }
            else { gender = "Other"; }

            con.Open();
            SqlCommand c= new SqlCommand("exec InsertEmp '" + userId + "','" + firstName + "','" + lastName + "','" + DOB + "','" + gender +
                "','" + email + "','" + mobile + "','" + address + "', '" + JD + "','" + Pass + "' " ,con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            //c.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered...");
           
            this.Hide();
            Login log = new Login();
            log.Show();
            

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}