using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1.BL
{
    internal class Class_connexion
    {
        //fonction pour verifier la connexion
        public bool ValidationConnexion(string Nom , string mdp)
        {
            if(Nom == "Admin" && mdp == "Adminmdp")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
