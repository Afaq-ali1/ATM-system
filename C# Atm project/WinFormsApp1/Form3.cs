using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        Account account;
        public static Form3 instance;
        public TextBox tb1;
        public Label lb1;
        public Form3(Account obj)
        {
            InitializeComponent();
            this.account = obj;
            instance = this;
            tb1 = textBox1;
            //lb1 = label4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int baln;
            string textBox = textBox1.Text;
            if (int.TryParse(textBox, out baln))
            {
                account.Withdraw(baln);
            }
            else
            {
                MessageBox.Show("You entered invalid input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(account);
            form.Show();
        }
    }
}
