using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObserverLibrary.ObserverLibrary;

namespace ConversorMoneda
{
    public partial class Form1 : Form
    {
        private Subject sujeto;
        private DolarEeuuObservador DEEUUObservador;
        private RealBrasilObservador RBObservador;
        private YenJaponesObservador YJaponesObservador;
        private YuanChinoObservador YNChinoObservador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //IMPLEMENTANDO EL PATRON DE DISEÑO
            sujeto = new Subject();
            DEEUUObservador = new DolarEeuuObservador(sujeto);
            RBObservador = new RealBrasilObservador(sujeto);
            YJaponesObservador = new YenJaponesObservador(sujeto);
            YNChinoObservador = new YuanChinoObservador(sujeto);
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtPeso.Text != "" && txtPeso.Text != "," && txtPeso.Text != ".")
            {
                sujeto.Estado = Double.Parse(txtPeso.Text.Replace(',', '.'), CultureInfo.GetCultureInfo("en-US"));
                lblDolar.Text = string.Format("{0:0.##}", Convert.ToString(DEEUUObservador.Result));
                lblReal.Text = string.Format("{0:0.##}", Convert.ToString(RBObservador.Result));
                lblYen.Text = string.Format("{0:0.##}", Convert.ToString(YJaponesObservador.Result));
                lblYuan.Text = string.Format("{0:0.##}", Convert.ToString(YNChinoObservador.Result));
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                txtPeso.Text = "";
            }
        }
    }
}
