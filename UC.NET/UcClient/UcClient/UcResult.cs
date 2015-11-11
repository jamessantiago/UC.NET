using System;

namespace UcNetClient
{
    public class UcResult<TResult> : IUcResult<TResult>
    {
        public TResult Value { get; set; }

        public Exception Exception { get; set; }
    }
}