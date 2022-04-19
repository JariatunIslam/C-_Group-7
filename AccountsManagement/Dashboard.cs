using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AccountsManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
      
        string userName;
        public Dashboard( string s)
        {
            userName = s;
            InitializeComponent();


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log=new Login();
            log.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_List el = new Employee_List();
            el.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sales s=new Sales();
            s.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Payroll pr= new Payroll();
            pr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Purchase p=new Purchase();  
            p.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stock st=new Stock();
            st.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Expense expense=new Expense();  
            expense.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profit_Loss__Per_month pl=new Profit_Loss__Per_month();
            pl.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (userName == "admin") {
                button8.Hide();

            }
            else {
                button8.Hide();
                button2.Hide();
                button10.Hide();
                button5.Hide();
              }





        }
    }
}
