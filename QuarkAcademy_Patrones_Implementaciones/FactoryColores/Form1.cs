using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAzul.BackColor = Color.Blue;
            panelRojo.BackColor = Color.Red;
            panelAmarillo.BackColor = Color.Yellow;
            
            /* ESTA ES LA FORMA DE PODER UTILIZAR EL HEXA EN LOS BACKCOLOR
             * string hexColor = "#626262";
            Color myColor = System.Drawing.ColorTranslator.FromHtml(hexColor);
            panelAzul.BackColor = myColor;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("ijfoisjdfs");
            listView1.Items[0].BackColor = Color.Blue;
        }
    }
}
