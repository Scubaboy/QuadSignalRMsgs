using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadSignalRMsgs.HubResponces
{
    public class ReceiveResponce
    {
        private readonly bool msgProcessed;

        public ReceiveResponce(bool msgProcessed)
        {
            this.msgProcessed = msgProcessed;
        }

        public bool MsgProcessed
        {
            get
            {
                return this.msgProcessed;
            }
        }
    }
}
