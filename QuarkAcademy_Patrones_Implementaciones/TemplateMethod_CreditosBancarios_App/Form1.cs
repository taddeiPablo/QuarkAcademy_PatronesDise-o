using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TemplateMethodLibrary;

namespace TemplateMethod_CreditosBancarios_App
{
    public partial class Form1 : Form
    {
        List<Cliente> _clientes;
        List<String> _creditos;
        public Form1()
        {
            InitializeComponent();
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente() { Nombre = "Roberto Gómez" });
            _clientes.Add(new Cliente() { Nombre = "Marta Sánchez" });
            this.comboBox1.DataSource = _clientes;

            _creditos = new List<String>();
            _creditos.Add("Personal");
            _creditos.Add("Hipotecario");
            this.comboBox2.DataSource = _creditos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var credito = this.comboBox2.SelectedItem.ToString();
            var cliente = (Cliente)this.comboBox1.SelectedItem;
            try
            {
                if (credito == null) throw new Exception("Debe seleccionar un cliente");

                Credito c;

                switch (credito)
                {
                    case "Hipotecario":
                        c = new CreditoHipotecario(cliente);
                        break;
                    case "Personal":
                        c = new CreditoPersonal(cliente);
                        break;
                    default:
                        throw new Exception("Debe seleccionar un crédito");
                }
                this.richTextBox1.Clear();
                this.richTextBox1.Lines = c.Verificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
