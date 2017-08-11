using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public int MaxValue;
        Random rand = new Random();
        int randomNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\n");
            randomNumber = rand.Next(0, MaxValue + 1);
            textBox1.AppendText("O número é: " + randomNumber);
            //checkBox1.Enabled = !checkBox1.Enabled;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "OI, EU SOU O GOKU";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label.Text = trackBar1.Value.ToString();
            MaxValue = trackBar1.Value;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
