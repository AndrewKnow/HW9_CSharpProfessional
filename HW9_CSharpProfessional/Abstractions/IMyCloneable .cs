using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharpProfessional.Abstractions
{
    public interface IMyCloneable<T>
    {
        T MyCloneBicycle();
        (string, string, string) GetBicycleInfo();
    }
}
