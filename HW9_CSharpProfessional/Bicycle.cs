using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharpProfessional
{
    public class Bicycle : IMyCloneable<Bicycle>, ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Bicycle CloneBicycle()
        {
            throw new NotImplementedException();
        }
    }
}
