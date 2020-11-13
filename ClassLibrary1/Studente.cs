using System;
using System.Collections.Generic;
using System.Text;

namespace Classi
{
    internal class Studente : Persona
    {
        private string Classe { get; set; }

        public List<Docente> Docenti { get; private set; } = new List<Docente>();

        public Studente(string c)
        {
            Nome = base.Nome;
            Cognome = base.Cognome;
            DataNascita = base.DataNascita;
            Altezza = base.Altezza;
            Classe = c;
        }
        
        public void AddDocente(Docente doc)
        {
            Docenti.Add(doc);
        }
    }
}
