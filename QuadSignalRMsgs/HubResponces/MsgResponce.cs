using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadSignalRMsgs.HubResponces
{
    public class MsgResponce
    {
        private bool actioned;
        private int quadId;

        public MsgResponce(bool actioned, int quadId)
        {
            this.actioned = actioned;
            this.quadId = quadId;
        }

        public bool Actioned
        {
            get
            {
                return this.actioned;
            }
        }

        public int QuadId
        {
            get
            {
                return this.quadId;
            }
        }
    }
}
