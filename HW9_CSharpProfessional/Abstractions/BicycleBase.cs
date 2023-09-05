using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharpProfessional.Abstractions
{
    /// <summary>
    /// Родительский класс
    /// </summary>
    public class BicycleBase: IMyCloneable<BicycleBase>, ICloneable
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public BicycleBase(string brand, string type, string size)
        {
            Brand = brand;
            Type = type;
            Size = size;
        }

        public BicycleBase MyCloneBicycle()
        {
            return new BicycleBase(Brand, Type, Size);
        }

        public (string, string, string) GetBicycleInfo()
        {
            return (Brand, Type, Size);
        }

        public object Clone()
        {
            return MyCloneBicycle();
        }
    }
}
