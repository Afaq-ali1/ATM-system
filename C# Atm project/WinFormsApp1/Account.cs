using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Account
    {
        public int pass;
        public int balance;
        public Account(int p, int b)
        {
            pass = p;
            balance = b;
        }
        public void Display(int fbal)
        {
            MessageBox.Show("Balance is: " + balance);
        }
        public void Withdraw(int formBal)
        {

            if (formBal <= balance && formBal > 0)
            {
                balance = balance - formBal;
                MessageBox.Show("Balance is: " + balance);
            }
            else
            {
                MessageBox.Show("Not Enough Balance ");
            }

        }
        public void Deposit(int formBal)
        {
            if (formBal > 0)
            {

                balance += formBal;
                MessageBox.Show("Balance is: " + balance);
            }
            else
            {
                MessageBox.Show("You entered Invalid Amount", "Invalid amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
