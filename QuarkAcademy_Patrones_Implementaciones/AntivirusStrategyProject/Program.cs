using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AntivirusStrategyLibrary;
using AntivirusStrategyLibrary.Entities;
using AntivirusStrategyLibrary.Interfaces;

namespace AntivirusStrategyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aqui veremos el funcionamiento del antivirus simples :");
            Contexto context = new Contexto(new AntivirusSimple());
            context.ejecutar();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("aqui veremos el funcionamiento del antivirus mas avanzado : ");
            Contexto context2 = new Contexto(new AntivirusAvanzado());
            context2.ejecutar();
            Console.WriteLine("------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
