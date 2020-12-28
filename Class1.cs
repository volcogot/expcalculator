using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class exponentiation
    {
        public string a, b;
        public exponentiation(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string ogo()
        {
            return "" + Math.Pow(Double.Parse(a),Double.Parse(b));
        }
        public string Clear()
        {
            return "";
        }
    }
}

