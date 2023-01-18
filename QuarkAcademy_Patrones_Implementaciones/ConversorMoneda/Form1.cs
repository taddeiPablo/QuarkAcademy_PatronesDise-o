using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private PesoArgObservador pArgObservador;
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
            sujeto = new Subject();
            DEEUUObservador = new DolarEeuuObservador(sujeto);
            RBObservador = new RealBrasilObservador(sujeto);
            YJaponesObservador = new YenJaponesObservador(sujeto);
            YNChinoObservador = new YuanChinoObservador(sujeto);
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            sujeto.Estado = Convert.ToDouble(txtPeso.Text);
            lblDolar.Text = string.Format("#.#", Convert.ToString(DEEUUObservador.Result));
            lblReal.Text = string.Format("#.#", Convert.ToString(RBObservador.Result));
            lblYen.Text = string.Format("#.#", Convert.ToString(YJaponesObservador.Result));
            lblYuan.Text = string.Format("#.#", Convert.ToString(YNChinoObservador.Result));
        }
    }
}
