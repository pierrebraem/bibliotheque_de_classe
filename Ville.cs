using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Ville:Nommage
    {
        private static Int32 leMaxId = 1;
        private string leCodePostal;

        public Ville() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setCodePostal("");
        }

        public Ville(Int32 unID) : base(unID)
        {
            setMaxId(unID + 1);
            setCodePostal("");
        }

        public Ville(Int32 unID, string unLibelle) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
            setCodePostal("");
        }

        public Ville(Int32 unId, string unLibelle, string unCodePostal) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            setCodePostal(unCodePostal);
        }

        public Ville(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setCodePostal("");
        }

        public Ville(string unLibelle, string unCodePostal) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setCodePostal(unCodePostal);
        }

        public void setMaxId(Int32 unMaxId)
        {
            if (unMaxId > leMaxId)
                leMaxId = unMaxId;
        }

        public void setCodePostal(string unCodePostal)
        {
            leCodePostal = unCodePostal;
        }

        public Int32 getMaxId()
        {
            return leMaxId;
        }

        public string getCodePostal()
        {
            return leCodePostal;
        }
    }
}
