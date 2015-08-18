
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
        /// Creates a hub to quad responce.
        /// </summary>
        /// <param name="responce">Responce</param>
        /// <param name="quadId">Id of quad to receive the responce</param>
        public Responce(byte[] responce, int quadId)
        {
            this.responce = responce;
            this.quadId = quadId;
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
