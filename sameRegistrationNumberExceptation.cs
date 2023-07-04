using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class sameRegistrationNumberExceptation : ApplicationException
    {
        student A { get; set; }

        student B { get; set; }

        public sameRegistrationNumberExceptation(student A , student B)
        {
            this.A = A;
                this.B = B;
        }

        public override string ToString()
        {
            return $"{A.ToString()} {B.ToString()} have the same registration number";
        }
    }
}
