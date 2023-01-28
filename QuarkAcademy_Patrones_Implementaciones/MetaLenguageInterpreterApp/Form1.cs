using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetaLanguageinterpreterLibrary;
using MetaLanguageinterpreterLibrary.Interface;
using MetaLanguageinterpreterLibrary.keywords;

namespace MetaLenguageInterpreterApp
{
    public partial class Form1 : Form
    {

        private Context context;
        private TransformTextPlan_in_TextHtml Ttp_in_TH;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new Context();
            /* ESTA ES LA FORMA DE CARGAR UN HTML CREADO DESDE UN STRING
            webBrowser1.Refresh();
            var str = "<html><head></head><body>" + "<h1>FUNCIONA</h1>" + "</body></html>";
            webBrowser1.DocumentText = str;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ttp_in_TH = new TransformTextPlan_in_TextHtml(richTextBox1.Text);
            Ttp_in_TH.interpret(context);
            string result = TemplateHtml.getTemplate(context.getTextHtml());
            webBrowser1.Refresh();
            webBrowser1.DocumentText = result;
        }
    }
}
