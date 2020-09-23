using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Padawan.Hotel.Util
{
    public class UtilResult
    {
        public class Result<T>
        {
            public T Data { get; set; }
            public HttpStatusCode Status { get; set; }
            public bool Error { get; set; }
            public string Message { get; set; }
        }
    }
}
