using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejo_de_imagenes_SingletonLibrary;

namespace manejo_de_imagenes_Singleton
{
    public partial class Form1 : Form
    {
        private DataBaseFlags dBaseFlags;
        public Form1()
        {
            InitializeComponent();
            this.dBaseFlags = DataBaseFlags.getInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = this.dBaseFlags.getPaises();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pais = comboBox1.SelectedItem.ToString();
            this.dBaseFlags = DataBaseFlags.getInstance(); // aqui pongo a prueba el patron singleton para ver si esta funcionando correctamente
            string path = this.dBaseFlags.getBandera(pais);
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
