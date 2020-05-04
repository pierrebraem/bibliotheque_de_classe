using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque_de_classe
{
    class Situation_Famille:Nommage
    {
        private static Int32 leMaxId = 1;

        public Situation_Famille() : base(leMaxId)
        {
            setMaxId(leMaxId + 1);
        }

        public Situation_Famille(Int32 unID) : base (unID)
        {
            setMaxId(unID + 1);
        }

        public Situation_Famille(Int32 unID, string unLibelle) : base(unID, unLibelle)
        {
            setMaxId(unID + 1);
        }

        public Situation_Famille(string unLibelle) : base(leMaxId, unLibelle)
        {
            setMaxId(leMaxId + 1);
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
    }
}
