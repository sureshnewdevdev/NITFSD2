using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NITFSD2
{
    public class MyOwnException : Exception
    {
        string customerMessage = "As per this progem, input should be proper. Please correct you in and outputs";
        public MyOwnException() { }


        public MyOwnException(string message)
        {
            customerMessage = message;
        }

        public override string Message => customerMessage;
    }
}
