using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        Account account;
        public Form4(Account obj)
        {
            InitializeComponent();
            this.account = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cashWithdraw_Click(object sender, EventArgs e)
        {
            account.Withdraw(1000);
        }

        private void balanceInquiry_Click(object sender, EventArgs e)
        {
            account.Withdraw(5000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            account.Withdraw(10000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Withdraw(15000);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            account.Withdraw(20000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account.Withdraw(25000);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(account);
            form.Show();
        }
    }
}
