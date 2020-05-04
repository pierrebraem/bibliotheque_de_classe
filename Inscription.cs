using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Inscription
    {
        private Parent leParent, leResponsable, leResponsablePaiement1, leResponsablePaiement2;
        private Ville laVille;
        private List<Enfant> lesEnfants;
        private Situation_Famille laSituationFamille;
        private List<Ecole> lesEcolesEtLesDatesDeSignature;
        private Hopital lHopital;
        private Autorite_Parentale lAutoriteParentale;

        private int lId = 1, leNb_Enfant_Charge;
        private string lAdresse, laCAF, lePortable_Prioritaire, laDate_Inscrption;
        private bool laPhoto_YN, laCle_Wallonnienne_YN;

        public Inscription()
        {
            setId(1);
            SetNb_Enfant_Charge(0);
            SetAdresse("");
            SetCAF("");
            SetPortable_Prioritaire("");
            SetDate_Inscrption("");
            SetPhoto_YN(false);
            SetCle_Wallonnienne_YN(false);
            SetParent(new Parent());
            setResponsable(new Parent());
            setResponsablePaiement1(new Parent());
            setResponsablePaiement2(new Parent());
            SetVille(new Ville());
            SetEnfant(new List<Enfant>());
            SetSituation_Famille(new Situation_Famille());
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(new Parent());
            setResponsable(new Parent());
            setResponsablePaiement1(new Parent());
            setResponsablePaiement2(new Parent());
            SetVille(new Ville());
            SetEnfant(new List<Enfant>());
            SetSituation_Famille(new Situation_Famille());
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge, Parent unParent, Parent unResponsable, Parent unResponsabledePaiement1, Parent unResponsabledePaiement2)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(unParent);
            setResponsable(unResponsable);
            setResponsablePaiement1(unResponsabledePaiement1);
            setResponsablePaiement2(unResponsabledePaiement2);
            SetVille(new Ville());
            SetEnfant(new List<Enfant>());
            SetSituation_Famille(new Situation_Famille());
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge, Parent unParent, Parent unResponsable, Parent unResponsabledePaiement1, Parent unResponsabledePaiement2, Ville uneVille)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(unParent);
            setResponsable(unResponsable);
            setResponsablePaiement1(unResponsabledePaiement1);
            setResponsablePaiement2(unResponsabledePaiement2);
            SetVille(uneVille);
            SetEnfant(new List<Enfant>());
            SetSituation_Famille(new Situation_Famille());
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge, Parent unParent, Parent unResponsable, Parent unResponsabledePaiement1, Parent unResponsabledePaiement2, Ville uneVille, List<Enfant> desEnfants)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(unParent);
            setResponsable(unResponsable);
            setResponsablePaiement1(unResponsabledePaiement1);
            setResponsablePaiement2(unResponsabledePaiement2);
            SetVille(uneVille);
            SetEnfant(desEnfants);
            SetSituation_Famille(new Situation_Famille());
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge, Parent unParent, Parent unResponsable, Parent unResponsabledePaiement1, Parent unResponsabledePaiement2, Ville uneVille, List<Enfant> desEnfants, Situation_Famille uneSituationFamille)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(unParent);
            setResponsable(unResponsable);
            setResponsablePaiement1(unResponsabledePaiement1);
            setResponsablePaiement2(unResponsabledePaiement2);
            SetVille(uneVille);
            SetEnfant(desEnfants);
            SetSituation_Famille(uneSituationFamille);
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge, Parent unParent, Parent unResponsable, Parent unResponsabledePaiement1, Parent unResponsabledePaiement2, Ville uneVille, List<Enfant> desEnfants, Situation_Famille uneSituationFamille, List<Ecole> desEcoles)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(unParent);
            setResponsable(unResponsable);
            setResponsablePaiement1(unResponsabledePaiement1);
            setResponsablePaiement2(unResponsabledePaiement2);
            SetVille(uneVille);
            SetEnfant(desEnfants);
            SetSituation_Famille(uneSituationFamille);
            SetEcoles(new List<Ecole>());
            setHopital(new Hopital());
            setAutoriteParentale(new Autorite_Parentale());
        }

        public Inscription(int unId, string uneAdresse, string CAF, string unPortable_Prioritaire, string uneDate_Inscription, bool unePhoto_YN, bool uneCleWallonnaine, int Nb_Enfant_Charge, Parent unParent, Parent unResponsable, Parent unResponsabledePaiement1, Parent unResponsabledePaiement2, Ville uneVille, Hopital unHopital, List<Enfant> desEnfants, Situation_Famille uneSituation_Famille, Autorite_Parentale uneAutoriteParentale, List<Ecole> desEcoles)
        {
            setId(unId);
            SetNb_Enfant_Charge(Nb_Enfant_Charge);
            SetAdresse(uneAdresse);
            SetCAF(CAF);
            SetPortable_Prioritaire(unPortable_Prioritaire);
            SetDate_Inscrption(uneDate_Inscription);
            SetPhoto_YN(unePhoto_YN);
            SetCle_Wallonnienne_YN(uneCleWallonnaine);
            SetParent(unParent);
            setResponsable(unResponsable);
            setResponsablePaiement1(unResponsabledePaiement1);
            setResponsablePaiement2(unResponsabledePaiement2);
            SetVille(uneVille);
            SetEnfant(desEnfants);
            SetSituation_Famille(uneSituation_Famille);
            SetEcoles(desEcoles);
            setHopital(unHopital);
            setAutoriteParentale(uneAutoriteParentale);
        }

        public void setId(int unId)
        {
            lId = unId;
        }

        public int getId()
        {
            return lId;
        }

        public void SetParent(Parent unParent)
        {
            leParent = unParent;
        }

        public Parent getParent()
        {
            return leParent;
        }

        public void setHopital(Hopital unHopital)
        {
            lHopital = unHopital;
        }

        public Hopital getHopital()
        {
            return lHopital;
        }

        public void setResponsable(Parent unResponsable)
        {
            leResponsable = unResponsable;
        }

        public Parent getResponsable()
        {
            return leResponsable;
        }

        public void setResponsablePaiement1(Parent unResponsablePaiement1)
        {
            leResponsablePaiement1 = unResponsablePaiement1;
        }

        public Parent getResponsablePaiement1()
        {
            return leResponsablePaiement1;
        }

        public void setResponsablePaiement2(Parent unResponsablePaiment2)
        {
            leResponsablePaiement2 = unResponsablePaiment2;
        }

        public Parent getResponsablePaiement2()
        {
            return leResponsablePaiement2;
        }

        public void SetVille(Ville uneVille)
        {
            laVille = uneVille;
        }

        public Ville getVille()
        {
            return laVille;
        }

        public void SetEnfant(List<Enfant> desEnfants)
        {
            lesEnfants = desEnfants;
        }

        public List<Enfant> getEnfant()
        {
            return lesEnfants;
        }

        public void SetSituation_Famille(Situation_Famille uneSituation_Famille)
        {
            laSituationFamille = uneSituation_Famille;
        }

        public Situation_Famille GetSituastion_Famille()
        {
            return laSituationFamille;
        }

        public void SetEcoles(List<Ecole> desEcoles)
        {
            lesEcolesEtLesDatesDeSignature = desEcoles;
        }

        public List<Ecole> GetEcoles()
        {
            return lesEcolesEtLesDatesDeSignature;
        }

        public void SetNb_Enfant_Charge(int unNb_Enfant_Charge)
        {
            leNb_Enfant_Charge = unNb_Enfant_Charge;
        }
        public int getNb_Enfant_Charge()
        {
            return leNb_Enfant_Charge;
        }
        public void SetAdresse(string uneAdresse)
        {
            lAdresse = uneAdresse;
        }
        public string getAdresse()
        {
            return lAdresse;
        }
        public void SetCAF(string uneCAF)
        {
            laCAF = uneCAF;
        }
        public string getCAF()
        {
            return laCAF;
        }
        public void SetPortable_Prioritaire(string unPortable_Prioritaire)
        {
            lePortable_Prioritaire = unPortable_Prioritaire;
        }
        public string getPortable_Prioritaire()
        {
            return lePortable_Prioritaire;
        }
        public void SetDate_Inscrption(string uneDate_Inscrption)
        {
            laDate_Inscrption = uneDate_Inscrption;
        }
        public string getDate_Inscrption()
        {
            return laDate_Inscrption;
        }
        public void SetPhoto_YN(bool unePhoto_YN)
        {
            laPhoto_YN = unePhoto_YN;
        }
        public bool getPhoto_YN()
        {
            return laPhoto_YN;
        }
        public void SetCle_Wallonnienne_YN(bool unCle_Wallonnienne_YN)
        {
            laCle_Wallonnienne_YN = unCle_Wallonnienne_YN;
        }
        public bool getCle_Wallonnienne_YN()
        {
            return laCle_Wallonnienne_YN;
        }

        public void setAutoriteParentale(Autorite_Parentale uneAutoriteParentale)
        {
            lAutoriteParentale = uneAutoriteParentale;
        }

        public Autorite_Parentale GetAutorite_Parentale()
        {
            return lAutoriteParentale;
        }
    }
}
