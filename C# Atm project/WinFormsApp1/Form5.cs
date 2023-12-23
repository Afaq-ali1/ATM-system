using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        Account account;
        public Form5(Account obj)
        {
            InitializeComponent();
            this.account = obj;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baln;
            string textBox = textBox1.Text;
            if (int.TryParse(textBox, out baln))
            {
                account.Deposit(baln);
            }
            else
            {
                MessageBox.Show("You entered invalid input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(account);
            form.Show();
        }
    }
}
