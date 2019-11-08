using System;
using System.Runtime.Serialization;

namespace HaromszogekSzoftverfejleszto.Modell
{
    [Serializable]
    internal class ModellException : Exception
    {
        public ModellException()
        {
        }

        public ModellException(string message) : base(message)
        {
        }

        public ModellException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}