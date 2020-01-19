using System;
using System.Collections.Generic;
using System.Text;

namespace SpyStore.Dal.Exceptions
{
    //SpyStoreConcurrencyException.cs
    public class SpyStoreConcurrencyException : SpyStoreException
    {
        public SpyStoreConcurrencyException() { }
        public SpyStoreConcurrencyException(string message) : base(message) { }
        public SpyStoreConcurrencyException(
        string message, Exception innerException)
        : base(message, innerException) { }
    }
}
