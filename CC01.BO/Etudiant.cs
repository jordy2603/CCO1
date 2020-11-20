using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Matricule { get; set; }
        string Email { get; set; }

        public Etudiant()
        {
        }

        public Etudiant(string nom, string prenom, string matricule, string email)
        {
            Nom = nom;
            Prenom = prenom;
            Matricule = matricule;
            Email = email;
        }
    }
}
