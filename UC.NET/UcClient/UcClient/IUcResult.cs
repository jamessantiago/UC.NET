using System;

namespace UcNetClient
{
    public interface IUcResult<TResult>
    {
        TResult Value { get; set; }

        Exception Exception { get; set; }
    }
}