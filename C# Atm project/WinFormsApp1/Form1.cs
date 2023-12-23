using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bank b;
        public static Form1 instance;
        public Label lb1;              
        public Form1()
        {
            b = new Bank();
            InitializeComponent();
            instance = this;
            lb1 = label1;  
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            int pin;
            string inputText = textBox1.Text;
            textBox1.Clear();
            textBox1.Focus();
            if (int.TryParse(inputText, out pin))  
            {
                b.accounts(pin);
            }
            else
            {
                MessageBox.Show("You entered invalid input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                textBox1.Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

     
    }

}

