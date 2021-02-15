using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult // IResult ekleyerek tekrardan aynı fonksiyonları yazmaktan kurtulduk.
    {
        T Data { get; }
    }
}
