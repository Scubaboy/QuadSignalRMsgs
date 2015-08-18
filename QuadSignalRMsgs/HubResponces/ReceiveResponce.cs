namespace QuadSignalRMsgs.HubResponces
{
    /// <summary>
    /// Notifies a client that the hub has processed the clients message.
    /// </summary>
    public class ReceiveResponce
    {
        /// <summary>
        /// Indicates that the message has been processed.
        /// </summary>
        private readonly bool msgProcessed;

        /// <summary>
        /// ReceiveResponce constructor
        /// </summary>
        /// <param name="msgProcessed">Message process status.</param>
        public ReceiveResponce(bool msgProcessed)
        {
            this.msgProcessed = msgProcessed;
        }

        /// <summary>
        /// Gets the message process status.
        /// </summary>
        public bool MsgProcessed
        {
            get
            {
                return this.msgProcessed;
            }
        }
    }
}
