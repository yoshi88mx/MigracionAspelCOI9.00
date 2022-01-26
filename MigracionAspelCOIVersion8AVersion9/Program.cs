using System;
using System.IO;
using System.Linq;

namespace MigracionAspelCOIVersion8AVersion9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Any())
            {
                if (Directory.Exists(args[0]))
                {
                    var carpetaRaiz = args[0];
                    var carpetaBasesDatos = Path.Combine(args[0], "Datos");
                    if (Directory.Exists(carpetaBasesDatos))
                    {
                        Console.WriteLine($"{nameof(carpetaBasesDatos)}:{carpetaBasesDatos}");
                        var carpetas = Directory.GetDirectories(carpetaBasesDatos);
                        foreach (var carpeta in carpetas)
                        {
                            Console.WriteLine($"{nameof(carpeta)}:{carpeta}");
                            var archivos = Directory.GetFiles(carpeta, "*.fdb");
                            if (archivos.Any(t => t.Contains("COI80")))
                            {
                                var fdb = new FileInfo(archivos.FirstOrDefault(t => t.ToLower().EndsWith(".fdb")));
                                Console.WriteLine($"{nameof(fdb)}:{fdb}");
                                File.Move(fdb.FullName, fdb.FullName.Replace("COI80", "COI90"));
                                Console.WriteLine($"{nameof(fdb)}:{fdb.FullName.Replace("COI80", "COI90")}");
                                Console.WriteLine("Finaliza Renombre");
                            }
                        }
                    }
                    var archivoConexiones = Path.Combine(carpetaRaiz + @"\Conexiones.ini");
                    if (File.Exists(archivoConexiones))
                    {
                        var textoConexiones = File.ReadAllText(archivoConexiones);
                        textoConexiones = textoConexiones.Replace("COI8.00", "COI9.00");
                        textoConexiones = textoConexiones.Replace("COI80Empre", "COI90Empre");
                        File.WriteAllText(Path.Combine(carpetaRaiz, "Conexiones9.ini"), textoConexiones);
                    }
                    Console.ReadLine();
                }
                
            }
            
        }
    }
}
