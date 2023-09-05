using HW9_CSharpProfessional.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_CSharpProfessional.Implementations
{
    /// <summary>
    ///  Класс наследующий BicycleBase 
    /// </summary>
    public class Bicycle : BicycleBase, ICloneable
    {
        private string _brand { get; set; }
        private string _type { get; set; }
        private string _size { get; set; }

        public Bicycle(string brand, string type, string size) : base(brand, type, size)
        {
            _brand = brand;
            _type = type;
            _size = size;  
        }

        public new object Clone()
        {
            return MyCloneBicycle();
        }

        public (string, string, string) GetBicycleInfo()
        {
            return (_brand,_type, _size);
        }

        public BicycleBase MyCloneBicycle()
        {
            Bicycle bicycle = new(_brand, _type, _size);
            return bicycle;
        }
    }
}
