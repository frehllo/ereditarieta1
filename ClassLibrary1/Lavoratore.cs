using System;
using System.Collections.Generic;
using System.Text;

namespace Classi
{
    internal class Lavoratore : Persona
    {
        internal double Stipendio { get; set; }

        public Lavoratore(double s)
        {
            Nome = base.Nome;
            Cognome = base.Cognome;
            Stipendio = s;
            Altezza = base.Altezza;
            DataNascita = base.DataNascita;
        }
    }
}
