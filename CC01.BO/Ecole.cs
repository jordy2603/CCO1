using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Ecole
    {
        string Nom_ecole { get; set; }
        string Localisation { get; set; }

        public Ecole()
        {
        }

        public Ecole(string nom_ecole, string localisation)
        {
            Nom_ecole = nom_ecole;
            Localisation = localisation;
        }
    }
}
