using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Ecole:Nommage
    {
        private static Int32 leMaxId = 1;
        private List<Inscription> lesInscriptions;
        private List<Matiere> lesMatieres;

        public Ecole() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setInscriptions(new List<Inscription>());
            setMatieres(new List<Matiere>());
        }

        public Ecole(Int32 unID) : base(unID)
        {
            setMaxId(unID + 1);
            setInscriptions(new List<Inscription>());
            setMatieres(new List<Matiere>());
        }

        public Ecole(Int32 unID, string unLibelle) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
            setInscriptions(new List<Inscription>());
            setMatieres(new List<Matiere>());
        }

        public Ecole(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setInscriptions(new List<Inscription>());
            setMatieres(new List<Matiere>());
        }

        public Ecole(string unLibelle, List<Inscription> desInscriptions) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setInscriptions(desInscriptions);
            setMatieres(new List<Matiere>());
        }

        public Ecole(string unLibelle, List<Inscription> desInscriptions, List<Matiere> desMatieres) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setInscriptions(desInscriptions);
            setMatieres(desMatieres);
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

        public void setInscriptions(List<Inscription> desInscriptions)
        {
            lesInscriptions = desInscriptions;
        }

        public List<Inscription> getInscriptions()
        {
            return lesInscriptions;
        }

        public void setMatieres(List<Matiere> desMatieres)
        {
            lesMatieres = desMatieres;
        }

        public List<Matiere> getMatieres()
        {
            return lesMatieres;
        }
    }
}
