using System;

namespace RisNetClient
{
    public class RisResult<TResult> : IRisResult<TResult>
    {
        public TResult Value { get; set; }

        public Exception Exception { get; set; }
    }
}