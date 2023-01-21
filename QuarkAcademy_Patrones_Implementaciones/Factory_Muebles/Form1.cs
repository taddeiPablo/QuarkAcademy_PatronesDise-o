using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Muebles
{
    public partial class Form1 : Form
    {
        private string mueble;
        private string tipomueble;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mueble = comboBox1.SelectedText;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipomueble = comboBox2.SelectedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
