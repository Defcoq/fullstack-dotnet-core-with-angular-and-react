using System;
using System.Collections.Generic;
using System.Text;

namespace SpyStore.Dal.Exceptions
{
    //SpyStoreInvalidQuantityException.cs
    public class SpyStoreInvalidQuantityException : SpyStoreException
    {
        public SpyStoreInvalidQuantityException() { }
        public SpyStoreInvalidQuantityException(string message) : base(message) { }
        public SpyStoreInvalidQuantityException(
        string message, Exception innerException)
        : base(message, innerException) { }
    }
}
