using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divicion_constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DIVICION dividir = new DIVICION(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = dividir.dividir().ToString();
        }
    }
}
