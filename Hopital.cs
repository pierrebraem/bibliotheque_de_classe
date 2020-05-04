using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Hopital:Residence
    {
        private static Int32 leMaxId = 1;
        private string leTel;

        public Hopital() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            setTel("");
        }

        public Hopital(Int32 unId) : base(unId)
        {
            setMaxId(unId + 1);
            setTel("");
        }

        public Hopital(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            setTel("");
        }

        public Hopital(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setTel("");
        }

        public Hopital(string unLibelle, string unTel) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            setTel(unTel);
        }

        public Hopital(Int32 unID, string unLibelle, string uneAdresse, string unTel) : base(unID, unLibelle, uneAdresse)
        {
            setMaxId(unID + 1);
            setTel(unTel);
        }

        public void setTel(string unTel)
        {
            leTel = unTel;
        }

        public string getTel()
        {
            return leTel;
        }
    }
}
