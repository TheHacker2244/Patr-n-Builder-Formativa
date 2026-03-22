using System;
using System.Collections.Generic;

namespace Patron_Builder_Formativa.Caso2_Reporte
{
    public class Reporte
    {
        public string Titulo { get; set; }
        public string Autor { get; set; } 
        public List<string> Secciones { get; set; } = new List<string>();

        public void Mostrar()
        {
            Console.WriteLine($"\n--- {Titulo} ---");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine(new string('-', 20));
            foreach (var seccion in Secciones)
            {
                Console.WriteLine(seccion);
            }
        }
    }
}