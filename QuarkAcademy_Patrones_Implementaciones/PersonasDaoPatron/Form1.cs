using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PersonasDaoLibrary.DaoImplements;
using PersonasDaoLibrary.Interface;
using PersonasDaoLibrary.Model;
using PersonasDaoLibrary.Conexiones;

namespace PersonasDaoPatron
{
    public partial class Form1 : Form
    {
        private List<Persona> listados;
        private Iconexiones tipoConexion;
        private PersonaDaoImp personDaoImp;
        private Persona persona;
        private bool delalista = false;
        private bool reload = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tipoConexion = new Conexiones("","","");
            personDaoImp = new PersonaDaoImp(tipoConexion);
            listPersonas.DataSource = personDaoImp.ListaTodos();
            delalista = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!delalista)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtId.Text));
                personDaoImp.registrar(persona);
                reloadList();
                MessageBox.Show("SE GUARDO CON EXITO LA PERSONA", "ATENTION");
            }
        }

        private void reloadList()
        {
            reload = false;
            listPersonas.DataSource = null;
            listPersonas.DataSource = personDaoImp.ListaTodos();
            reload = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (delalista)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtId.Text));
                personDaoImp.actualizar(persona);
                MessageBox.Show("SE ACTUALIZO CON EXITO LA INFORMACION", "ATENTION");
                reloadList();
            }
        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reload)
            {
                string itemstr = listPersonas.SelectedItem.ToString();
                int index = listPersonas.FindString(itemstr);
                if (index != -1)
                {
                    delalista = true;
                    string[] arrayItem = itemstr.Split(';');
                    txtNombre.Text = arrayItem[0].Trim();
                    txtApellido.Text = arrayItem[1].Trim();
                    txtId.Text = arrayItem[2].Trim();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            reload = false;
            persona = personDaoImp.leerPorId(Convert.ToInt32(txtId.Text));
            personDaoImp.eliminar(persona.Id);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtId.Text = "";
            MessageBox.Show("SE ELIMINO CON EXITO ", "ATENTION");
            reload = true;
            reloadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            delalista = false;
        }
    }
}
