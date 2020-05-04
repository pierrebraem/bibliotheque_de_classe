using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Inscrire
    {
        private string laDateSignature;
        

        public Inscrire()
        {
            setDateSignature("");
        }

        public Inscrire(string uneDateSignature)
        {
            setDateSignature(uneDateSignature);
        }

        public void setDateSignature(string uneDateSignature)
        {
            laDateSignature = uneDateSignature;
        }

        public string getDateSignature()
        {
            return laDateSignature;
        }
    }
}
