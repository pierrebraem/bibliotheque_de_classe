using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Parent:Residence
    {
        private static Int32 leMaxId = 1;
        private string lePrenom, leTel_Portable, leTel_Domicile, leTel_Travail, leCourriel;

        public Parent() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
            SetPrenom("");
            SetTel_Portable("");
            SetTel_Domicile("");
            SetTel_Travail("");
            SetCourriel("");
        }

        public Parent(Int32 unId) : base(unId)
        {
            setMaxId(unId + 1);
            SetPrenom("");
            SetTel_Portable("");
            SetTel_Domicile("");
            SetTel_Travail("");
            SetCourriel("");
        }

        public Parent(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            setMaxId(unId + 1);
            SetPrenom("");
            SetTel_Portable("");
            SetTel_Domicile("");
            SetTel_Travail("");
            SetCourriel("");
        }

        public Parent(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
            SetPrenom("");
            SetTel_Portable("");
            SetTel_Domicile("");
            SetTel_Travail("");
            SetCourriel("");
        }

        public Parent(Int32 unID, string unLibelle, string unPrenom, string uneAdresse, string unTel_Portable, string unTel_Domicile, string unTel_Travail, string unCourriel) : base(unID, unLibelle, uneAdresse)
        {
            setMaxId(unID + 1);
            SetPrenom(unPrenom);
            SetTel_Portable(unTel_Portable);
            SetTel_Domicile(unTel_Domicile);
            SetTel_Travail(unTel_Travail);
            SetCourriel(unCourriel);
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
        public void SetTel_Portable(string unTel_Portable)
        {
            leTel_Portable = unTel_Portable;
        }
        public string getTel_Portable()
        {
            return leTel_Portable;
        }
        public void SetTel_Domicile(string unTel_Domicile)
        {
            leTel_Domicile = unTel_Domicile;
        }
        public string getTel_Domicile()
        {
            return leTel_Domicile;
        }
        public void SetTel_Travail(string unTel_Travail)
        {
            leTel_Travail = unTel_Travail;
        }
        public string getTel_Travail()
        {
            return leTel_Travail;
        }
        public void SetCourriel(string unCourriel)
        {
            leCourriel = unCourriel;
        }
        public string getCourriel()
        {
            return leCourriel;
        }
    }
}
