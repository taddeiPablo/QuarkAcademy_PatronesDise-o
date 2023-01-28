using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MetaLanguageinterpreterLibrary.Interface;

namespace MetaLanguageinterpreterLibrary
{
    public class TransformTextPlan_in_TextHtml : IExpression
    {

        private string textPlain;

        public TransformTextPlan_in_TextHtml(string text)
        {
            textPlain = text;
        }

        public void interpret(Context context)
        {
            context.transform(textPlain);
        }
    }
}
