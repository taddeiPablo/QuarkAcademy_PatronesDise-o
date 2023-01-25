using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_imagenes_SingletonLibrary
{
    public class DataBaseFlags
    {
        private static DataBaseFlags _instance;
        private List<string> paises;
        private Dictionary<string, string> dicBanderas;
        private string environment = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Environment.CurrentDirectory))), "Manejo_de_imagenes_SingletonLibrary");
        private string PathFolder = "flags";
        private DataBaseFlags()
        {
            this.paises = new List<string>();
            this.paises.Add("Argentina");
            this.paises.Add("brazil");
            this.paises.Add("Venezuela");
            this.paises.Add("Colombia");
            this.paises.Add("Chile");
            this.paises.Add("Peru");
            this.paises.Add("Bolivia");
            this.paises.Add("United_States");
            this.paises.Add("Canada");
            this.paises.Add("England");
            this.paises.Add("España");
            this.paises.Add("Germany");
            this.paises.Add("Mexico");
            this.paises.Add("Paraguay");
            this.paises.Add("Rusia");
            this.paises.Add("Uruguay");
            string pathFlags = Path.Combine(environment, PathFolder);
            string pathFile = string.Empty;
            dicBanderas = new Dictionary<string, string>();
            foreach (string pais in paises)
            {
                if (Directory.Exists(pathFlags))
                {
                    pathFile = Path.Combine(pathFlags,pais) + ".png";
                    if (File.Exists(pathFile))
                    {
                        //pathBanderas.Add(pathFile);
                        dicBanderas.Add(pais, pathFile);
                    }
                }
            }
        }

        public static DataBaseFlags getInstance()
        {
            if (_instance == null)
            {
                _instance = new DataBaseFlags();
            }
            return _instance;
        }

        public List<string> getPaises()
        {
            return paises;
        }

        public string getBandera(string pais)
        {
            return dicBanderas[pais];
        }
    }
}
