using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) // this -> class'ın kendisi(ex. Result) - aşağıdaki overload fonksiyonunu çalıştırır.
        {
            Message = message;
        }

        public Result(bool success) // Sistemde mesaj iletmek istemiyor isek overload kullanarak sadece success döndürebiliriz.
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }  // 'get' -readonly- bir yapı olduğu için sadece constructor'da güncellenebilir.
    }
}
