using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson01_A1_CSharp
{
    public partial class Lesson01_A1 : Form
    {
        private Random rand = new Random();

        public Lesson01_A1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color randColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            BackColor = randColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                richTextBox1.Text = textBox1.Text.ToUpper();
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
