using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Matiere:Nommage
    {
        private static Int32 leMaxId = 1;
        private List<Cours> lesCours;
        private Ecole lEcole;

        public Matiere() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setCours(new List<Cours>());
            setEcole(new Ecole());
        }

        public Matiere(Int32 unID) : base(unID)
        {
            setMaxId(unID + 1);
            setCours(new List<Cours>());
            setEcole(new Ecole());
        }

        public Matiere(Int32 unID, string unLibelle) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
            setCours(new List<Cours>());
            setEcole(new Ecole());
        }

        public Matiere(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setCours(new List<Cours>());
            setEcole(new Ecole());
        }

        public Matiere(string unLibelle, Ecole uneEcole) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setCours(new List<Cours>());
            setEcole(uneEcole);
        }

        public Matiere(string unLibelle, Ecole uneEcole, List<Cours> desCours) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setCours(desCours);
            setEcole(uneEcole);
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

        public void setEcole(Ecole uneEcole)
        {
            lEcole = uneEcole;
        }

        public Ecole getEcole()
        {
            return lEcole;
        }

        public void setCours(List<Cours> desCours)
        {
            lesCours = desCours;
        }

        public List<Cours> getCours()
        {
            return lesCours;
        }
    }
}
