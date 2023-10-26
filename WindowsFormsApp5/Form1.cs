using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sum = 1;
        int factorial = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                factorial = int.Parse(textBox1.Text);
            }
            catch 
            
            {
                MessageBox.Show("Not a number");
                return;
            }
            if (factorial < 0) 
            {
                MessageBox.Show("Negative number");
                return;
            }else if(factorial == 0)
            {
                label1.Text = "1";
                sum = 1;
                return;
            }
            for (int count = 1; count <= factorial; count++) 
            {
                sum = sum * count;
            }
            label1.Text = sum.ToString();
            sum = 1;
            
        }
    }
}
