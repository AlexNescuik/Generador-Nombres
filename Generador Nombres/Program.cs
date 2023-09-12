using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador_Nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tipos1 =
            {
                "normal", "fuego", "agua", "planta", "bicho", "siniestro", "dragón", "eléctrico",
            "hada", "lucha", "fantasma", "psíquico"
            };

            int cantElms = tipos1.Length;
            Console.WriteLine($"¿Qué tipo de pokemon serías según tu cumpleaños?{Environment.NewLine}{Environment.NewLine}Tu mes:{Environment.NewLine}");

            //elementos del arreglo
           for (int i = 0; i < tipos1.Length; i++)
           {
                Console.WriteLine(i + ".-" + tipos1[i]);
           }

            string[] tipos2 =
            {
                "tierra", "lucha", "hielo", "agua", "veneno", "fantasma", "fuego", "acero", "psíquico", 
            "roca", "normal", "volador", "bicho", "fuego", "agua", "planta", "roca", "siniestro", "dragón", 
            "eléctrico", "hada", "lucha", "fantasma", "psíquico", "acero", "volador", "dragón","eléctrico",
            "veneno","hielo","planta"
            };

            int cantElms2 = tipos2.Length;
            Console.WriteLine($"{Environment.NewLine}Tu día:{Environment.NewLine}");

            //elementos del arreglo 2
            for (int i = 0; i < tipos2.Length; i++)
            {
                Console.WriteLine(i + ".-" + tipos2[i]);
            }
            Console.Read();
        }
    }
}
