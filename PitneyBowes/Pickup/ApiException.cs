using System.Runtime.Serialization;

namespace PitneyBowes.Pickup
{
    [Serializable]
    internal class ApiException : Exception
    {
        private int v1;
        private string v2;

        public ApiException()
        {
        }

        public ApiException(string? message) : base(message)
        {
        }

        public ApiException(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public ApiException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}