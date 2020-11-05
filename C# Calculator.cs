using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        String input1 = ""; //Gets input from first textbox
        String input2 = ""; //Gets input from second textbox


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(input1, out num1))
            {
                if (int.TryParse(input2, out num2))
                {
                    String output = (num1 + num2).ToString();
                    label1.Text = output;
                }
                else
                    label1.Text = "Invalid Syntax";
            }
            else
            {
                label1.Text = "Invalid Syntax";
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            input2 = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
