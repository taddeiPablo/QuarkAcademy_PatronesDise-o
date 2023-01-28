using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetaLanguageinterpreterLibrary.Interface;
using MetaLanguageinterpreterLibrary.keywords;

namespace MetaLanguageinterpreterLibrary
{
    public class Context
    {
        private Keyword keywords;
        private string plane_text_final;

        public Context()
        {
            keywords = Keyword.getInstance();
        }

        public void transform(string plane_text)
        {
            foreach (KeyValuePair<string, string> item in keywords.KeywordDic)
            {
                if (plane_text.Contains(item.Key))
                {
                   plane_text =  plane_text.Replace(item.Key, item.Value);
                }
            }
            plane_text_final = plane_text;
        }

        public string getTextHtml()
        {
            return this.plane_text_final;
        }
    }
}
