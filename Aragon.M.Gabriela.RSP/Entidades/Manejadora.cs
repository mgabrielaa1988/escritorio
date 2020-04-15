﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.SP
{
    public class Manejadora
    {
        public void Guardar(double precio)
        {
            StreamWriter auxWriter;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\PrecioCajon.txt";

            if ((auxWriter = new StreamWriter(path, true)) != null)
            {
                string auxTexto = DateTime.Now.ToString() + " Precio total del Cajón: " + precio.ToString();

                auxWriter.WriteLine(auxTexto);
            }

            auxWriter.Close();

        }

    }
}
