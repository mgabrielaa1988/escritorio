using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase14;

namespace Clase14Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string mostrar = "";
            int opcion;
            AdministradorDeArchivos.Escribir(@"D:\VisualStudio\Aragon.Gabriela.2A\texto.txt", "Prueba");
            Console.WriteLine("Guardar archivo en: \n1-Escritorio\n2-Mis Documentos\n3-Mis Imagenes");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //AdministradorDeArchivos.Escribir(@"C:\Users\alumno\Desktop\texto.txt", "Prueba");
                    //AdministradorDeArchivos.Leer(@"C:\Users\alumno\Desktop\texto.txt", out mostrar);
                    AdministradorDeArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\texto.txt", "Prueba 2");
                    AdministradorDeArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\texto.txt", out mostrar);
                    break;
                case 2:
                    //AdministradorDeArchivos.Escribir(@"D:\MisDocumentos\texto.txt", "Prueba");
                    //AdministradorDeArchivos.Leer(@"D:\MisDocumentos\texto.txt", out mostrar);
                    AdministradorDeArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\texto.txt", "Prueba 2");
                    AdministradorDeArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\texto.txt", out mostrar);
                    break;
                case 3:
                    //AdministradorDeArchivos.Escribir(@"C:\users\alumno\Pictures\texto.txt", "Prueba");
                    //AdministradorDeArchivos.Leer(@"C:\users\alumno\Pictures\texto.txt", out mostrar);
                    AdministradorDeArchivos.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\texto.txt", "Prueba 2");
                    AdministradorDeArchivos.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\texto.txt", out mostrar);
                    break;
                default:
                    AdministradorDeArchivos.Escribir(AppDomain.CurrentDomain.BaseDirectory + "\\texto.txt", "Prueba 3");
                    AdministradorDeArchivos.Leer(AppDomain.CurrentDomain.BaseDirectory + "\\texto.txt", out mostrar);
                    break;
            }
            AdministradorDeArchivos.Leer(@"D:\VisualStudio\Aragon.Gabriela.2A\texto.txt", out mostrar);
            Console.WriteLine(mostrar);
            Console.ReadLine();


        }
    }
}
