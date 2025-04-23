using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text +"1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text +"3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            texttotal.Text = texttotal.Text + "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(texttotal.Text);

            texttotal.Clear();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(texttotal.Text);

            texttotal.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(texttotal.Text);

            texttotal.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(texttotal.Text);

            texttotal.Clear();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            texttotal.Clear();
            result = (0);
            num1=(0);
            num2=(0);
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(texttotal.Text);

            if (option.Equals("+"))
                result=num1+num2;

            if (option .Equals ("-"))
                result = num1 - num2;

            if (option .Equals ("*"))
                result = num1 * num2;

            if (option .Equals ("/"))
                result = num1 / num2;


            texttotal.Text = result + "";
        }
    }
}
