using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Autorite_Parentale:Nommage
    {
        private static Int32 leMaxId = 1;

        public Autorite_Parentale() : base(leMaxId)
        {
            SetMaxId(leMaxId + 1);
        }

        public Autorite_Parentale(Int32 unId) : base(unId)
        {
            SetMaxId(unId + 1);
        }

        public Autorite_Parentale(Int32 unId, string unLibelle) : base(unId, unLibelle)
        {
            SetMaxId(unId + 1);
        }

        public Autorite_Parentale(string unLibelle) : base(leMaxId, unLibelle)
        {
            SetMaxId(leMaxId + 1);
        }

        public void SetMaxId(Int32 unMaxId)
        {
            if (unMaxId > leMaxId)
                leMaxId = unMaxId;
        }

        public Int32 getMaxId()
        {
            return leMaxId;
        }
    }
}
