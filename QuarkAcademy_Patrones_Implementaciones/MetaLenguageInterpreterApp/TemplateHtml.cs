using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLenguageInterpreterApp
{
    public static class TemplateHtml
    {
        private static StringBuilder templateHtml;

        public static string getTemplate(string textHtml)
        {
            templateHtml = new StringBuilder();
            templateHtml.Append("<html>");
            templateHtml.AppendLine("<head>");
            templateHtml.AppendLine("</head>");
            templateHtml.AppendLine("<body>");
            templateHtml.AppendFormat("{0}", textHtml);
            templateHtml.AppendLine("</body>");
            templateHtml.AppendLine("</html>");
            return templateHtml.ToString();
        }
    }
}
