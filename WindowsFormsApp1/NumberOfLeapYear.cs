using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NumberOfLeapYear : Form
    {
        public NumberOfLeapYear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int initial_year = Convert.ToInt32(this.textBox1.Text);
            int final_year = Convert.ToInt32(this.textBox2.Text);
            int iterator;
            int number_of_leap_year = 0;
            for(iterator = initial_year + 1; iterator < final_year; iterator++)
            {
                if (iterator % 100 == 0)
                {
                    if (iterator % 400 == 0)
                    {
                        number_of_leap_year = number_of_leap_year + 1;
                    }
                    else if (iterator % 400 != 0)
                    {
                        number_of_leap_year = number_of_leap_year;
                    }
                }
                else if (iterator % 100 != 0)
                {
                    if (iterator % 4 == 0)
                    {
                        number_of_leap_year = number_of_leap_year + 1;
                    }
                    else if (iterator % 4 != 0)
                    {
                        number_of_leap_year = number_of_leap_year;
                    }
                }
            }
            MessageBox.Show("There are " + number_of_leap_year.ToString() + " leap years between " + initial_year.ToString() + " and " + final_year.ToString() + ".");
        }
    }
}
