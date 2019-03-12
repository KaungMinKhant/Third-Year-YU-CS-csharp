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
    public partial class LeapYearTestercs : Form
    {
        public LeapYearTestercs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int initial_year, final_year, your_year;
            initial_year = Convert.ToInt32(textBox1.Text);
            final_year = Convert.ToInt32(textBox2.Text);
            your_year = Convert.ToInt32(textBox3.Text);
            if(your_year > initial_year && your_year < final_year)
            {
                if(your_year % 100 == 0)
                {
                    if(your_year % 400 == 0)
                    {
                        MessageBox.Show("Leap Year");
                    }
                    else if(your_year % 400 != 0)
                    {
                        MessageBox.Show("Not Leap Year");
                    }
                }
                else if(your_year % 100 != 0)
                {
                    if(your_year % 4 == 0)
                    {
                        MessageBox.Show("Leap Year");
                    }
                    else if(your_year % 4 != 0)
                    {
                        MessageBox.Show("Not Leap Year");
                    }
                }
            }
            else if(your_year < initial_year || your_year > final_year)
            {
                MessageBox.Show("Out of Range");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int initial_year, final_year, result;
            result = 0;
            initial_year = Convert.ToInt32(textBox1.Text);
            final_year = Convert.ToInt32(textBox2.Text);
            for (int i = initial_year + 1; i < final_year; i++)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    {

                        result++;
                    }
                    else if (i % 400 != 0)
                    {
                        
                    }
                }
                else if (i % 100 != 0)
                {
                    if (i % 4 == 0)
                    {
                        result++;
                    }
                    else if (i % 4 != 0)
                    {
                      
                    }
                }
            }
            MessageBox.Show(result.ToString());
        }
    }
}
