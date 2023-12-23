using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{

    public class Bank
    {
        private int pintry = 1;
        public int admin = 22;
        Account a1 = new Account(1111, 10000);
        Account a2 = new Account(2222, 20000);
        Account a3 = new Account(3333, 30000);
        Account a4 = new Account(4444, 40000);
        Account a5 = new Account(5555, 50000);
        public void accounts(int formpin)
        {
            if (pintry < 4)
            {
                if (formpin == a1.pass)
                {
                     Form1.instance.Hide();
                    Form2 fa1 = new Form2(a1);
                    fa1.Show();
                }
                else if (formpin == a2.pass)
                {
                    Form1.instance.Hide();
                    Form2 fa2 = new Form2(a2);
                    fa2.Show();
                }
                else if (formpin == a3.pass)
                {
                    Form1.instance.Hide();
                    Form2 fa3 = new Form2(a3);
                    fa3.Show();
                }
                else if (formpin == a4.pass)
                {
                    Form1.instance.Hide();
                    Form2 fa4 = new Form2(a4);
                    fa4.Show();
                }
                else if (formpin == a5.pass)
                {
                    Form1.instance.Hide();
                    Form2 fa5 = new Form2(a5);
                    fa5.Show();
                }
                else { MessageBox.Show("Wrong pin code in " + pintry + " attempt out of 3"); }
            }

            if (pintry == 3)
            {
                MessageBox.Show("Service is disabled,Please enter admin pin");
                Form1.instance.lb1.Text = " ENTER ADMIN PIN ";

            }
            else if (pintry == 4)
            {
                if (formpin == admin)
                {
                    MessageBox.Show("Service is enable now");
                    Form1.instance.lb1.Text = " Enter Your 4 digit Pin ";
                    pintry = 0;
                }
            }
            else if (pintry > 4)
            { Application.Exit(); }
            pintry++;
        }

    }
}
