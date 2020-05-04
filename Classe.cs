using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Classe:Nommage
    {
        private static Int32 leMaxId = 1;
        private Etablissement_Scolaire lEtablisementScolaire;


        public Classe() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setEtablissementScolaire(new Etablissement_Scolaire());
        }

        public Classe(Int32 unID) : base(unID)
        {
            setMaxId(unID + 1);
            setEtablissementScolaire(new Etablissement_Scolaire());
        }

        public Classe(Int32 unID, string unLibelle) : base (unID, unLibelle)
        {
            setMaxId(unID + 1);
            setEtablissementScolaire(new Etablissement_Scolaire());
        }

        public Classe(string unLibelle) : base (leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setEtablissementScolaire(new Etablissement_Scolaire());
        }

        public Classe(string unLibelle, Etablissement_Scolaire unEtablissementScolaire) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setEtablissementScolaire(unEtablissementScolaire);
        }

        public Classe(Int32 unId, string unLibelle, Etablissement_Scolaire unEtablissementScolaire) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            setEtablissementScolaire(unEtablissementScolaire);
        }

        public void setMaxId(Int32 unMaxId)
        {
            if (unMaxId > leMaxId)
                leMaxId = unMaxId;
        }

        public Int32 getMaxId()
        {
            return leMaxId;
        }

        public void setEtablissementScolaire(Etablissement_Scolaire unEtablissementScolaire)
        {
            lEtablisementScolaire = unEtablissementScolaire;
        }

        public Etablissement_Scolaire getEtablissement_Scolaire()
        {
            return lEtablisementScolaire;
        }
    }
}
