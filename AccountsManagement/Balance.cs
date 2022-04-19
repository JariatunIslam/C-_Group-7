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
    public partial class Profit_Loss__Per_month : Form
    {
        public Profit_Loss__Per_month()
        {
            InitializeComponent();
            con.Open();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Accounts_DB;Integrated Security=True");
        void GetList()
        {

            SqlCommand c = new SqlCommand("exec ShowBalance", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
       

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand("exec CurrentBalance", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView2.DataSource = dt;
           
        }
    }
}
