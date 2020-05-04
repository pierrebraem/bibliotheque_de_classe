using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Medecin:Residence
    {
        private string lePrenom, leTel;
        private static Int32 leMaxId = 1;

        public Medecin() : base(leMaxId)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom("");
            SetTel("");
        }

        public Medecin(Int32 unId) : base(unId)
        {
            SetMaxId(unId + 1);
            SetPrenom("");
            SetTel("");
        }

        public Medecin(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            SetMaxId(unId + 1);
            SetPrenom("");
            SetTel("");
        }

        public Medecin(string unLibelle) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom("");
            SetTel("");
        }

        public Medecin(string unLibelle, string uneAdresse, string unPrenom, string unTel) : base(leMaxId, unLibelle, uneAdresse)
        {
            SetMaxId(leMaxId + 1);
            SetPrenom(unPrenom);
            SetTel(unTel);
        }

        public Medecin(Int32 unID, string unLibelle, string unPrenom, string uneAdresse, string unTel) : base(unID, unLibelle, uneAdresse)
        {
            SetMaxId(unID + 1);
            SetPrenom(unPrenom);
            SetTel(unTel);
        }

        public void SetMaxId(Int32 unMaxId)
        {
            if (unMaxId > leMaxId)
                leMaxId = unMaxId;
        }

        public void SetPrenom(string unPrenom)
        {
            lePrenom = unPrenom;
        }
        public string getPrenom()
        {
            return lePrenom;
        }
        public void SetTel(string unTel)
        {
            leTel = unTel;
        }
        public string getTel()
        {
            return leTel;
        }
    }
}
