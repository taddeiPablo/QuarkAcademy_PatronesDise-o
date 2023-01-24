using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColoresFactoryLibrary;
using ColoresFactoryLibrary.colores;
using ColoresFactoryLibrary.Interface;

namespace FactoryColores
{
    public partial class Form1 : Form
    {
        private ColoresFactory cFabrica;
        private IColores icolores;
        private Color azulActual;
        private Color rojoActual;
        private Color amarilloActual;
        public Form1()
        {
            InitializeComponent();
            cFabrica = new ColoresFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAzul.BackColor = Color.FromArgb(17, 0, 255);
            panelRojo.BackColor = Color.FromArgb(255, 0, 0);            
            panelAmarillo.BackColor = Color.FromArgb(255, 251, 0);
        }

        // AZUL
        private void button1_Click(object sender, EventArgs e)
        {
            string tipo_color = "azul";
            try
            {
                icolores = cFabrica.getColores(tipo_color);
                if (listBox1.Items.Count == 0)
                {
                    azulActual = icolores.getNewColor(panelAzul.BackColor);
                }
                else
                {
                    azulActual = icolores.getNewColor(azulActual);
                }
                listBox1.Items.Add(icolores.getHexaColor());
                panelAzul.BackColor = azulActual;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "ATENCION");
            }
        }
        // ROJO
        private void button2_Click(object sender, EventArgs e)
        {
            string tipo_color = "rojo";
            try
            {
                icolores = cFabrica.getColores(tipo_color);
                if (listBox2.Items.Count == 0)
                {
                    rojoActual = icolores.getNewColor(panelRojo.BackColor);
                }
                else
                {
                    rojoActual = icolores.getNewColor(rojoActual);
                }
                listBox2.Items.Add(icolores.getHexaColor());
                panelRojo.BackColor = rojoActual;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "ATENCION");
            }
        }

        // AMARILLO
        private void button3_Click(object sender, EventArgs e)
        {
            string tipo_color = "amarillo";
            try
            {
                icolores = cFabrica.getColores(tipo_color);
                if (listBox3.Items.Count == 0)
                {
                    amarilloActual = icolores.getNewColor(panelAmarillo.BackColor);
                }
                else
                {
                    amarilloActual = icolores.getNewColor(amarilloActual);
                }
                listBox3.Items.Add(icolores.getHexaColor());
                panelAmarillo.BackColor = amarilloActual;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "ATENCION");
            }
        }
    }
}
