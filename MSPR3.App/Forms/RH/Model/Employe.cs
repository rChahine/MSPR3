using System;
using System.Collections.Generic;
using System.Text;

namespace MSPR3.App.Forms.RH.Model
{
    class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Service { get; set; }
        public string DateRecrutement { get; set; }

        public Employe(string nom, string prenom, string service, string dateRecrutement)
        {
            Nom = nom;
            Prenom = prenom;
            Service = service;
            DateRecrutement = dateRecrutement;
        }

    }
}