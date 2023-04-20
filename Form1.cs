using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_BBF_
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
           
        }
   

        public int Factorial(int x)
        {
            int f = 1;
            for (int i = x; i >=1; i--)
            {
                f = f * i;
            }
            return f;
        }
        public int power(int x,int n)
        {
            int r = 1;
            for (int i = 1; i <= n; i++)
            {
                r = r * x;
            }
            return r;

        }

        
        private void Add_Click(object sender, EventArgs e)
        {

            label3.Text = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)).ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {

            label3.Text = (Int32.Parse(textBox1.Text) - Int32.Parse(textBox2.Text)).ToString();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            label3.Text = (Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text)).ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            label3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();

        }

        private void Fac_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                label3.Text = Factorial(Int32.Parse(textBox1.Text)).ToString();
            }
            else if(textBox2.Text!="")
            {
                label3.Text = Factorial(Int32.Parse(textBox2.Text)).ToString();
            }
            
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            label3.Text = power(Int32.Parse(textBox1.Text),Int32.Parse(textBox2.Text)).ToString();
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            label3.Text = (Int32.Parse(textBox1.Text) % Int32.Parse(textBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
