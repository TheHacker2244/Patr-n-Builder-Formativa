using System;
using Patron_Builder_Formativa.Caso1_Usuario;
using Patron_Builder_Formativa.Caso2_Reporte;

namespace Patron_Builder_Formativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== SISTEMA DE CONSTRUCCIÓN (BUILDER PATTERN) ===");
            Console.ResetColor();

            // --- CASO 1: REGISTRO DE USUARIO ---
            var builderUser = new UsuarioBuilder("TheHacker2244", "dev@hacker.com")
                .ConRol("Administrator")
                .ConTelefono("+503 7000-0000")
                .Build();

            Console.WriteLine("\n[PROCESO] Generando Usuario...");
            Console.WriteLine(builderUser.ToString());


            // --- CASO 2: GENERACIÓN DE REPORTE ---
            var reporteDocs = new ReporteBuilder("Informe Semanal de C#")
                .DefinirAutor("TheHacker2244")
                .AgregarSeccion("Resumen", "Se implementó el patrón Builder con éxito.")
                .AgregarSeccion("Gráficos", "Diagrama de clases generado al 100%.")
                .AgregarSeccion("Conclusión", "El código es escalable y limpio.")
                .Build();

            Console.WriteLine("\n[PROCESO] Generando Reporte...");
            reporteDocs.Mostrar();

            Console.WriteLine("\n===============================================");
            Console.WriteLine("¡Ejecución completada con éxito, crack!");
            Console.ReadKey();
        }
    }
}