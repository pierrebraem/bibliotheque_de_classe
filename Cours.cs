using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Cours:Nommage
    {
        private static Int32 leMaxId = 1;
        private string leJour;
        private string lHeure_Debut;
        private string lHeure_Fin;
        private Matiere laMatiere;
        private List<Enfant> lesEnfants;

        public Cours() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setJour("");
            setHeure_Debut("88H88");
            setHeure_Fin("88H88");
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(Int32 unID) : base(unID)
        {
            setMaxId(unID + 1);
            setJour("");
            setHeure_Debut("88H88");
            setHeure_Fin("88H88");
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(Int32 unID, string unLibelle) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
            setJour("");
            setHeure_Debut("88H88");
            setHeure_Fin("88H88");
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(Int32 unID, string unLibelle, string unJour) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
            setJour(unJour);
            setHeure_Debut("88H88");
            setHeure_Fin("88H88");
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(Int32 unID, string unLibelle, string unJour, string uneHeure_Debut, string uneHeure_Fin) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
            setJour(unJour);
            setHeure_Debut(uneHeure_Debut);
            setHeure_Fin(uneHeure_Fin);
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setJour("");
            setHeure_Debut("88H88");
            setHeure_Fin("88H88");
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(string unLibelle, string unJour) : base (leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setJour(unJour);
            setHeure_Debut("88H88");
            setHeure_Fin("88H88");
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(string unLibelle, string unJour, string uneHeure_Debut, string uneHeure_Fin) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setJour(unJour);
            setHeure_Debut(uneHeure_Debut);
            setHeure_Fin(uneHeure_Fin);
            setMatiere(new Matiere());
            setEnfants(new List<Enfant>());
        }

        public Cours(string unLibelle, string unJour, string uneHeure_Debut, string uneHeure_Fin, Matiere uneMatiere) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setJour(unJour);
            setHeure_Debut(uneHeure_Debut);
            setHeure_Fin(uneHeure_Fin);
            setMatiere(uneMatiere);
            setEnfants(new List<Enfant>());
        }

        public Cours(string unLibelle, string unJour, string uneHeure_Debut, string uneHeure_Fin, Matiere uneMatiere, List<Enfant> desEnfants) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setJour(unJour);
            setHeure_Debut(uneHeure_Debut);
            setHeure_Fin(uneHeure_Fin);
            setMatiere(uneMatiere);
            setEnfants(desEnfants);
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

        public void setJour(string unJour)
        {
            leJour = unJour;
        }

        public string getJour()
        {
            return leJour;
        }

        public void setHeure_Debut(string uneHeure_Debut)
        {
            lHeure_Debut = uneHeure_Debut;
        }

        public string getHeure_Debut()
        {
            return lHeure_Debut;
        }

        public void setHeure_Fin(string uneHeure_Fin)
        {
            lHeure_Fin = uneHeure_Fin;
        }

        public string getHeure_Fin()
        {
            return lHeure_Fin;
        }

        public void setMatiere(Matiere uneMatiere)
        {
            laMatiere = uneMatiere;
        }

        public Matiere getMatiere()
        {
            return laMatiere;
        }

        public void setEnfants(List<Enfant> desEnfants)
        {
            lesEnfants = desEnfants;
        }

        public List<Enfant> getEnfants()
        {
            return lesEnfants;
        }
    }
}
