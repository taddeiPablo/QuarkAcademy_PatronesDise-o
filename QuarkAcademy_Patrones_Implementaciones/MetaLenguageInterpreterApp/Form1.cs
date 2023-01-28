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
            string defaultDoc = "#dv #h1 esto es un h1 #/h1 #p esto es un parrafo #/p #/dv";
            richTextBox1.Text = defaultDoc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ttp_in_TH = new TransformTextPlan_in_TextHtml(richTextBox1.Text);
            Ttp_in_TH.interpret(context);
            string result = TemplateHtml.getTemplate(context.getTextHtml());
            webBrowser1.Refresh();
            webBrowser1.DocumentText = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder guia = new StringBuilder();
            guia.Append("GUIA RAPIDA PARA LA UTILIZACION DE LA APP");
            guia.AppendLine("");
            guia.Append("ATENCION : NO INGRESAR LAS PALABRAS CLAVES EN MAYUCULAS");
            guia.AppendLine("");
            guia.AppendLine("#h1 --> <h1>");
            guia.AppendLine("#/h1 --> </h1>");
            guia.AppendLine("#h2 --> <h2>");
            guia.AppendLine("#/h2 --> </h2>");
            guia.AppendLine("#h3 --> <h3>");
            guia.AppendLine("#/h3 --> </h3>");
            guia.AppendLine("#h4--><h4>");
            guia.AppendLine("#/h4--></h4>");
            guia.AppendLine("#h5--><h5>");
            guia.AppendLine("#/h5--></h5>");
            guia.AppendLine("#h6--><h6>");
            guia.AppendLine("#/h6--></h6>");
            guia.AppendLine("#p--><p>");
            guia.AppendLine("#/p--></p>");
            guia.AppendLine("#b--><b>");
            guia.AppendLine("#/b--></b>");
            guia.AppendLine("#i--><i>");
            guia.AppendLine("#/i--></i>");
            guia.AppendLine("#u--><u>");
            guia.AppendLine("#/u--></u>");
            guia.AppendLine("#adds--><address>");
            guia.AppendLine("#/adds--></address>");
            guia.AppendLine("#art--><article>");
            guia.AppendLine("#/art--></article>");
            guia.AppendLine("#as--><aside>");
            guia.AppendLine("#/as--></aside>");
            guia.AppendLine("#ft--><footer>");
            guia.AppendLine("#/ft--></footer>");
            guia.AppendLine("#hd--><header>");
            guia.AppendLine("#/hd--></header>");
            guia.AppendLine("#mn--><main>");
            guia.AppendLine("#/mn--></main>");
            guia.AppendLine("#nv--><nav>");
            guia.AppendLine("#/nv--></nav>");
            guia.AppendLine("#sn--><section>");
            guia.AppendLine("#/sn--></section>");
            guia.AppendLine("#bq--><blockquote>");
            guia.AppendLine("#/bq--></blockquote>");
            guia.AppendLine("#dd--><dd>");
            guia.AppendLine("#/dd--></dd>");
            guia.AppendLine("#dv--><div>");
            guia.AppendLine("#/dv--></div>");
            guia.AppendLine("#dl--><dl>");
            guia.AppendLine("#/dl--></dl>");
            guia.AppendLine("#dt--><dt>");
            guia.AppendLine("#/dt--></dt>");
            guia.AppendLine("#fc--><figcaption>");
            guia.AppendLine("#/fc--></figcaption>");
            guia.AppendLine("#f--><figure>");
            guia.AppendLine("#/f--></figure>");
            guia.AppendLine("#hr--><hr />");
            guia.AppendLine("#li--><li>");
            guia.AppendLine("#/li--></li>");
            guia.AppendLine("#ul--><ul>");
            guia.AppendLine("#/ul--></ul>");
            guia.AppendLine("#menu--><menu>");
            guia.AppendLine("#/menu--></menu>");
            guia.AppendLine("#ol--><ol>");
            guia.AppendLine("#/ol--></ol>");
            guia.AppendLine("#pre--><pre>");
            guia.AppendLine("#a--><a href=''>");
            guia.AppendLine("#/a--></a>");
            guia.AppendLine("#br--><br />");
            guia.AppendLine("#span--><span>");
            guia.AppendLine("#strong--><strong>");
            guia.AppendLine("#/strong--></strong>");
            guia.AppendLine("#!-->&nbsp");
            guia.AppendLine("#!!!-->&nbsp&nbsp&nbsp");
            MessageBox.Show(guia.ToString(), "ATENCION");
        }
    }
}
