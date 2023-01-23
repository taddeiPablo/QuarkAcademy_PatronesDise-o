using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrica_mueble_Library.Fabricas;
using Fabrica_mueble_Library.Interface;
using Fabrica_mueble_Library.Muebles;

namespace Factory_Muebles
{
    public partial class Form1 : Form
    {
        private string mueble = string.Empty;
        private string tipomueble = string.Empty;
        private FabricaDeMuebles FdeMuebles;
        private IAbstractFactory fabricaMuebles;
        private IMueble productoTerminado;
        private List<IMueble> Listado_de_Muebles;
        public Form1()
        {
            InitializeComponent();
            FdeMuebles = new FabricaDeMuebles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listado_de_Muebles = new List<IMueble>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mueble = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipomueble = comboBox2.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mueble != string.Empty && tipomueble != string.Empty)
            {
                if (mueble == "silla")
                {
                    fabricaMuebles = FdeMuebles.getFactory(mueble);
                    productoTerminado = fabricaMuebles.getSilla(tipomueble);
                }
                if (mueble == "sofa")
                {
                    fabricaMuebles = FdeMuebles.getFactory(mueble);
                    productoTerminado = fabricaMuebles.getSofa(tipomueble);
                }
                if (mueble == "mesilla")
                {
                    fabricaMuebles = FdeMuebles.getFactory(mueble);
                    productoTerminado = fabricaMuebles.getMesilla(tipomueble);
                }
                Listado_de_Muebles.Add(productoTerminado);
                MessageBox.Show("!!! Mueble creado con exito !!!!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("por favor seleccione el mueble y su tipo antes de crearlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListado()
        {
            listBox1.Items.Clear();
            foreach (IMueble item in Listado_de_Muebles)
            {
                item.Visualizar();
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
    }
}
