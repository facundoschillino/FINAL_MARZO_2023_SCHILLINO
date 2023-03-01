using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trybook
{
    public class ReturnBoolString
    {
        public bool ReturnBool { get; set; }
        public string ReturnString { get; set; }

        public ReturnBoolString() { }

        public ReturnBoolString (bool returnBool, string returnString)
        {
            ReturnBool = returnBool;
            ReturnString = returnString;
        }
    }
}
