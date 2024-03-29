﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpyStore.Dal.Exceptions
{
    //SpyStoreRetryLimitExceededException.cs
    public class SpyStoreRetryLimitExceededException : SpyStoreException
    {
        public SpyStoreRetryLimitExceededException() { }
        public SpyStoreRetryLimitExceededException(string message) :
        base(message)
        { }
        public SpyStoreRetryLimitExceededException(
        string message, Exception innerException)
        : base(message, innerException) { }
    }
}
