
namespace HW9_CSharpProfessional.Implementations
{
    /// <summary>
    /// Класс наследник Bicycle
    /// </summary>
    public class MountainBicycle : Bicycle, ICloneable
    {
        public double Price;
        public MountainBicycle(string Brand, string Type, string Transmission, string Wheels, string Frame, double price) : base(Brand, Type, Transmission, Wheels, Frame)
        {
            Price = price;
        }

        public override MountainBicycle MyCloneBicycle()
        {
            return new MountainBicycle(Brand, Type, Transmission, Wheels, Frame, Price);
        }

        public override object Clone()
        {
            return MyCloneBicycle();
        }


    }
}
