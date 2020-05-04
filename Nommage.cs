using System;

namespace Bibliothèque_de_classe
{
    public class Nommage
    {
        private int lID;
        private string nom_libelle_intitule;

        public Nommage()
        {
            setID(0);
            setlibelle("");
        }

        public Nommage(int unID)
        {
            setID(unID);
            setlibelle("");
        }

        public Nommage(int unID, string unLibelle)
        {
            setID(unID);
            setlibelle(unLibelle);
        }

        public void setID(int unID)
        {
            lID = unID;
        }

        public void setlibelle(string unLibelle)
        {
            nom_libelle_intitule = unLibelle;
        }

        public int getID()
        {
            return lID;
        }

        public string getlibelle()
        {
            return nom_libelle_intitule;
        }
    }
}
