using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message) // base -> result'a dönmemizi sağlar ve oradaki uygun fonksiyonu çalıştırır.
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
