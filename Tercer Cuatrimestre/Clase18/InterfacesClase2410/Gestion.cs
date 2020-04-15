using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClase2410
{
    public static class Gestion
    {
        static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        static double MostrarImpuestoProvincia(IARBA bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
