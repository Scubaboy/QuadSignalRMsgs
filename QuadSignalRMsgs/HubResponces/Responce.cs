
namespace QuadSignalRMsgs.HubResponces
{
    /// <summary>
    /// Hub to client responce
    /// </summary>
    public class Responce
    {
        /// <summary>
        /// Responce to be sent to the quad
        /// </summary>
        private byte[] responce;
        
        /// <summary>
        /// Id of quad responce is intented for.
        /// </summary>
        private int quadId;

        /// <summary>
        /// Quad needs to send an ack to acknowledge receipt of message.
        /// </summary>
        private bool ackRequired;

        /// <summary>
        /// Creates a hub to quad responce.
        /// </summary>
        /// <param name="responce">Responce</param>
        /// <param name="quadId">Id of quad to receive the responce</param>
        /// <param name="ackRequired">Quad needs to send an ack to acknowledge receipt of message.</param>
        public Responce(byte[] responce, int quadId, bool ackRequired)
        {
            this.responce = responce;
            this.quadId = quadId;
            this.ackRequired = ackRequired;
        }

        /// <summary>
        /// Gets the message ack status.
        /// </summary>
        public bool AckRequired
        {
            get
            {
                return this.ackRequired;
            }
        }

        /// <summary>
        /// Gets the responce
        /// </summary>
        public byte[] ResponceForQuad
        {
            get
            {
                return this.responce;
            }
        }

        /// <summary>
        /// Gtes the quad Id.
        /// </summary>
        public int QuadId
        {
            get
            {
                return this.quadId;
            }
        }
    }
}
