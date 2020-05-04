using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Residence:Nommage
    {
        private static Int32 leMaxId = 1;
        private string lAdresse;
        private Ville laVille;

        public Residence() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setAdresse("");
            setVille(new Ville());
        }

        public Residence(Int32 unId) : base(unId)
        {
            setMaxId(unId + 1);
            setAdresse("");
            setVille(new Ville());
        }

        public Residence(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            setAdresse("");
            setVille(new Ville());
        }

        public Residence(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setAdresse("");
            setVille(new Ville());
        }

        public Residence(Int32 unId, string unLibelle, string uneAdresse) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            setAdresse(uneAdresse);
            setVille(new Ville());
        }

        public Residence(Int32 unId, string unLibelle, string uneAdresse, Ville uneVille) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            setAdresse(uneAdresse);
            setVille(uneVille);
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

        public void setAdresse(string uneAdresse)
        {
            lAdresse = uneAdresse;
        }
        public string getAdresse()
        {
            return lAdresse;
        }

        public void setVille(Ville uneVille)
        {
            laVille = uneVille;
        }

        public Ville getVille()
        {
            return laVille;
        }
    }
}
