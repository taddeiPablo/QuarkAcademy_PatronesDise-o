using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DiscograficaBuilderLibrary.Builder;
using DiscograficaBuilderLibrary.Entidades;

namespace DiscograficaBuilder
{
    public partial class Form1 : Form
    {
        // MATERIAL DISCOGRAFICO
        String nombre;
        Double precio;
        int stock;
        // AUTOR
        Autor autor;
        String nombreArtista;
        String descripcionArtista;
        // GENERO
        Genero genero;
        String descripcionGenero;
        // TIPO MATERIAL DISCOGRAFICO
        TipoMaterialDiscografico tipoMaterialDiscografico;
        String nombreMaterialDiscografico;
        // CANCIONES
        List<Cancion> canciones = new List<Cancion>();
        Cancion cancion;
        String nombreCancion;
        int duracionSegundos;

        MaterialDiscograficoBuilder builderMaterialDiscografico;
        MaterialDiscografico materialDiscografico;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaterial.Text != "" && txtPrecio.Text != "" && txtStock.Text != "" 
                && txtArtista.Text != "" && txtDescripcionArtista.Text != "" && txtGenero.Text != "")
            {
                nombre = txtMaterial.Text;
                precio = Convert.ToInt32(txtPrecio.Text);
                stock = Convert.ToInt32(txtStock.Text);
                nombreArtista = txtArtista.Text;
                descripcionArtista = txtDescripcionArtista.Text;
                descripcionGenero = txtGenero.Text;
                nombreMaterialDiscografico = txtmaterialDiscografico.Text;
                autor = new Autor(nombreArtista, descripcionArtista);
                genero = new Genero(descripcionGenero);
                tipoMaterialDiscografico = new TipoMaterialDiscografico(nombreMaterialDiscografico);
                CreacionMaterialDiscografico();
                MessageBox.Show("EL MATERIAL DISCOGRAFICO FUE GUARDADO CON EXITO","ATENCION");
            }
            else
            {
                MessageBox.Show("Por favor debe completar los campos de : Material discografico, Autor, Genero","ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreacionMaterialDiscografico()
        {
            builderMaterialDiscografico = new MaterialDiscograficoBuilder();
            materialDiscografico = builderMaterialDiscografico
                .ConNombre(nombre)
                .TienePrecio(precio)
                .EnStock(stock)
                .ComoAutor(autor)
                .ComoLista(canciones)
                .ComoGenero(genero)
                .ComoTipoMaterialDiscografico(tipoMaterialDiscografico)
                .BuildMaterialDiscografico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreCancion.Text != "" && txtDuracionDelTema.Text != "")
            {
                listBox1.Items.Clear();
                nombreCancion = txtNombreCancion.Text;
                duracionSegundos = Convert.ToInt32(txtDuracionDelTema.Text);
                cancion = new Cancion(nombreCancion, duracionSegundos);
                canciones.Add(cancion);
                cargarListBox();
            }
            else
            {
                MessageBox.Show("Por favor completo los campos sobre la cancion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarListBox()
        {
            foreach (Cancion can in canciones)
            {
                string strcancion = "Nombre de la Cancion : " + can.NombreCancion + "   Duracion del Tema :" + can.DuracionSegundos;
                listBox1.Items.Add(strcancion);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (materialDiscografico != null)
            {
                MessageBox.Show(materialDiscografico.reportarDatos(), "INFORME");
            }
            else
            {
                MessageBox.Show("Por Favor primero debe guardar la informacion cargada", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMaterial.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtArtista.Text = string.Empty;
            txtDescripcionArtista.Text = string.Empty;
            txtGenero.Text = string.Empty;
            txtNombreCancion.Text = string.Empty;
            txtDuracionDelTema.Text = string.Empty;
        }
    }
}
