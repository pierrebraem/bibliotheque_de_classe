using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Enfant:Nommage
    {
        private static Int32 leMaxId = 1;
        private string lePrenom, laDate_Naissance;
        private Classe laClasse;
        private List<Cours> lesCours;
        private List<Instrument> lesInstrumentsUtilises;

        public Enfant() : base (leMaxId)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom("");
            SetDate_Naissance("");
            setClasse(new Classe());
            setLesCours(new List<Cours>());
            setLesInstruments(new List<Instrument>());
        }

        public Enfant(Int32 unID) : base(unID)
        {
            SetMaxId(unID + 1);
            SetPrenom("");
            SetDate_Naissance("");
            setClasse(new Classe());
            setLesCours(new List<Cours>());
            setLesInstruments(new List<Instrument>());
        }

        public Enfant(Int32 unID, string unLibelle): base(unID, unLibelle)
        {
            SetMaxId(unID + 1);
            SetPrenom("");
            SetDate_Naissance("");
            setClasse(new Classe());
            setLesCours(new List<Cours>());
            setLesInstruments(new List<Instrument>());
        }

        public Enfant(string unLibelle) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom("");
            SetDate_Naissance("");
            setClasse(new Classe());
            setLesCours(new List<Cours>());
            setLesInstruments(new List<Instrument>());
        }

        public Enfant(string unLibelle , string unPrenom, string uneDate_Naissance) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom(unPrenom);
            SetDate_Naissance(uneDate_Naissance);
            setClasse(new Classe());
            setLesCours(new List<Cours>());
            setLesInstruments(new List<Instrument>());
        }
        public Enfant(string unLibelle, string unPrenom, string uneDate_Naissance, Classe uneClasse, List<Cours> desCours, List<Instrument> desInstruments) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom(unPrenom);
            SetDate_Naissance(uneDate_Naissance);
            setClasse(uneClasse);
            setLesCours(desCours);
            setLesInstruments(desInstruments);
        }


        public void SetMaxId(Int32 unMaxID)
        {
            if (unMaxID > leMaxId)
                leMaxId = unMaxID;
        }

        public Int32 GetMaxID()
        {
            return leMaxId;
        }

        public void SetPrenom(string unPrenom)
        {
            lePrenom = unPrenom;
        }
        public string getPenom()
        {
            return lePrenom;
        }
        public void SetDate_Naissance(string uneDate_Naissance)
        {
            laDate_Naissance = uneDate_Naissance;
        }
        public string getDate_Naissance()
        {
            return laDate_Naissance;
        }

        public void setClasse(Classe uneClasse)
        {
            laClasse = uneClasse;
        }

        public Classe getClasse()
        {
            return laClasse;
        }

        public void setLesInstruments(List<Instrument> desInstruments)
        {
            lesInstrumentsUtilises = desInstruments;
        }

        public List<Instrument> getInstruments()
        {
            return lesInstrumentsUtilises;
        }

        public void setLesCours(List<Cours> desCours)
        {
            lesCours = desCours;
        }

        public List<Cours> getCours()
        {
            return lesCours;
        }
    }
}
