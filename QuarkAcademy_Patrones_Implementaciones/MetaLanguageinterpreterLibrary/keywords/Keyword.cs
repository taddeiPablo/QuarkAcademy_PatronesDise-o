using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLanguageinterpreterLibrary.keywords
{
    public class Keyword
    {
        private static Keyword instance;
        private Dictionary<string, string> keywordDic;

        private Keyword()
        {
            keywordDic = new Dictionary<string, string>();
            keywordDic.Add("#h1", "<h1>");
            keywordDic.Add("#/h1", "</h1>");
            keywordDic.Add("#h2", "<h2>");
            keywordDic.Add("#/h2","</h2>");
            keywordDic.Add("#h3","<h3>");
            keywordDic.Add("#/h3", "</h3>");
            keywordDic.Add("#h4", "<h4>");
            keywordDic.Add("#/h4", "</h4>");
            keywordDic.Add("#h5", "<h5>");
            keywordDic.Add("#/h5", "</h5>");
            keywordDic.Add("#h6", "<h6>");
            keywordDic.Add("#/h6", "</h6>");
            keywordDic.Add("#p", "<p>");
            keywordDic.Add("#/p", "</p>");
            keywordDic.Add("#b", "<b>");
            keywordDic.Add("#/b", "</b>");
            keywordDic.Add("#i", "<i>");
            keywordDic.Add("#/i", "</i>");
            keywordDic.Add("#u", "<u>");
            keywordDic.Add("#/u", "</u>");
            keywordDic.Add("#adds", "<address>");
            keywordDic.Add("#/adds", "</address>");
            keywordDic.Add("#art", "<article>");
            keywordDic.Add("#/art", "</article>");
            keywordDic.Add("#as", "<aside>");
            keywordDic.Add("#/as", "</aside>");
            keywordDic.Add("#ft", "<footer>");
            keywordDic.Add("#/ft", "</footer>");
            keywordDic.Add("#hd", "<header>");
            keywordDic.Add("#/hd", "</header>");
            keywordDic.Add("#mn", "<main>");
            keywordDic.Add("#/mn", "</main>");
            keywordDic.Add("#nv", "<nav>");
            keywordDic.Add("#/nv", "</nav>");
            keywordDic.Add("#sn", "<section>");
            keywordDic.Add("#/sn", "</section>");
            keywordDic.Add("#bq", "<blockquote>");
            keywordDic.Add("#/bq", "</blockquote>");
            keywordDic.Add("#dd", "<dd>");
            keywordDic.Add("#/dd", "</dd>");
            keywordDic.Add("#dv", "<div>");
            keywordDic.Add("#/dv", "</div>");
            keywordDic.Add("#dl", "<dl>");
            keywordDic.Add("#/dl", "</dl>");
            keywordDic.Add("#dt", "<dt>");
            keywordDic.Add("#/dt", "</dt>");
            keywordDic.Add("#fc", "<figcaption>");
            keywordDic.Add("#/fc", "</figcaption>");
            keywordDic.Add("#f", "<figure>");
            keywordDic.Add("#/f", "</figure>");
            keywordDic.Add("#hr", "<hr />");
            keywordDic.Add("#li", "<li>");
            keywordDic.Add("#/li", "</li>");
            keywordDic.Add("#ul", "<ul>");
            keywordDic.Add("#/ul", "</ul>");
            keywordDic.Add("#menu", "<menu>");
            keywordDic.Add("#/menu", "</menu>");
            keywordDic.Add("#ol", "<ol>");
            keywordDic.Add("#/ol", "</ol>");
            keywordDic.Add("#pre", "<pre>");
            keywordDic.Add("#a", "<a href=''>");
            keywordDic.Add("#/a", "</a>");
            keywordDic.Add("#br", "<br />");
            keywordDic.Add("#span", "<span>");
            keywordDic.Add("#strong", "<strong>");
            keywordDic.Add("#/strong", "</strong>");
            keywordDic.Add("#!", "&nbsp");
            keywordDic.Add("#!!!", "&nbsp&nbsp&nbsp");
        }

        public Dictionary<string, string> KeywordDic { get => keywordDic; set => keywordDic = value; }

        public static Keyword getInstance()
        {
            if (instance == null)
            {
                instance = new Keyword();
            }
            return instance;
        }
    }
}
