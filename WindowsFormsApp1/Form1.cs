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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(this.textBox1.Text);
            if(year % 100 == 0)
            {
                if(year % 400 == 0)
                {
                    MessageBox.Show(this.textBox1.Text + " is a leap year");
                }
                else if(year % 400 != 0)
                {
                    MessageBox.Show(this.textBox1.Text + " is not aleap year");
                }
            }
            else if(year % 100 != 0)
            {
                if(year % 4 == 0)
                {
                    MessageBox.Show(this.textBox1.Text + " is a leap year");
                }
                else if(year % 4 != 0)
                {
                    MessageBox.Show(this.textBox1.Text + " is not aleap year");
                }
            }
        }
    }
}
