using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Exceptions
{
    public class ContentTypeException : Exception
    {
        public string Property {  get; set; }   
        public ContentTypeException(string? message, string property) : base(message)
        {
            Property = property;
        }
    }
}
