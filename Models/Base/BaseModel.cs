using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Models.Base
{
    public class BaseModel<T>
    {
        public StatusEnum Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }

    public enum StatusEnum
    {
        success = 1, empty = 2, error = 0
    }
}
