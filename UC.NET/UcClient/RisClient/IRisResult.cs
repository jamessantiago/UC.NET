using System;

namespace RisNetClient
{
    public interface IRisResult<TResult>
    {
        TResult Value { get; set; }

        Exception Exception { get; set; }
    }
}