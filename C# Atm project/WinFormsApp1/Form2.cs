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
    public partial class Form2 : Form
    {
        Account account;
        public static Form2 instance;

        public Form2(Account obj)
        {
            InitializeComponent();
            instance = this;
            this.account = obj;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2.instance.Hide();
            Form3 form3 = new Form3(account);
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.instance.Hide();
            Form4 form4 = new Form4(account);
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account.Display(account.balance);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2.instance.Hide();
            Form5 form = new Form5(account);
            form.Show();

        }
    }
}
