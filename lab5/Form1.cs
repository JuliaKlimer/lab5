using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Enabled = false;
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox1.Text.Length <= 10 && checkBox1.Enabled == true) 
            {
                checkBox1.Text = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true)
            {
                 int w = checkBox1.Width;
                 int h = checkBox1.Height;
                 w = Convert.ToInt32(textBox3.Text);
                 h = Convert.ToInt32(textBox2.Text);
                 checkBox1.Size = new Size(w,h);
            }
            else
            {
                MessageBox.Show("Please, turn on checkBox");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true && checkBox1.Location.X < 1000 || checkBox1.Location.Y < 500)
            {
                 int x = checkBox1.Location.X;
                 int y = checkBox1.Location.Y;
                 x = Convert.ToInt32(textBox4.Text);
                 y = Convert.ToInt32(textBox5.Text);
                 checkBox1.Location = new Point(x,y);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Enabled == true && checkBox1.Location.X < 1000 || checkBox1.Location.Y < 500)
            {                
                int x = e.X;
                int y = e.Y;
                checkBox1.Left = x;
                checkBox1.Top = y;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
