using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VuelosFacadeLibrary.fachada;

namespace FacadeVuelos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("implementando el patron( FACADE)");
            try
            {
                CheckFacade check1 = new CheckFacade();
                CheckFacade check2 = new CheckFacade();
                check1.buscar("1/26/2023", "2/28/2023", "Buenos Aires", "Tokyo");
                check2.buscar("1/26/2023", "2/06/2023", "Tokyo");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
