using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Utilisation
    {
        private bool leLouer;
        private Cours leCours;
        private Instrument lInstrument;
        private Enfant lEnfant;

        public Utilisation()
        {
            setLouer(false);
            setCours(new Cours());
            setInstrument(new Instrument());
            setEnfant(new Enfant());
        }

        public Utilisation(bool unLoueur)
        {
            setLouer(unLoueur);
            setCours(new Cours());
            setInstrument(new Instrument());
            setEnfant(new Enfant());
        }

        public Utilisation(bool unLoueur, Cours unCours)
        {
            setLouer(unLoueur);
            setCours(unCours);
            setInstrument(new Instrument());
            setEnfant(new Enfant());
        }

        public Utilisation(bool unLoueur, Cours unCours, Instrument unInstrument)
        {
            setLouer(unLoueur);
            setCours(unCours);
            setInstrument(unInstrument);
            setEnfant(new Enfant());
        }

        public Utilisation(bool unLoueur, Cours unCours, Instrument unInstrument, Enfant unEnfant)
        {
            setLouer(unLoueur);
            setCours(unCours);
            setInstrument(unInstrument);
            setEnfant(unEnfant);
        }

        public void setLouer(bool unLoueur)
        {
            leLouer = unLoueur;
        }

        public bool getLouer()
        {
            return leLouer;
        }

        public void setCours(Cours unCours)
        {
            leCours = unCours;
        }

        public Cours getCours()
        {
            return leCours;
        }

        public void setInstrument(Instrument unInstrument)
        {
            lInstrument = unInstrument;
        }

        public Instrument getInstrument()
        {
            return lInstrument;
        }

        public void setEnfant(Enfant unEnfant)
        {
            lEnfant = unEnfant;
        }

        public Enfant getEnfant()
        {
            return lEnfant;
        }
    }
}
