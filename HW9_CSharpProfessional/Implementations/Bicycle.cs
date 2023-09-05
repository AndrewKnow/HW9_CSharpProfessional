using HW9_CSharpProfessional.Abstractions;


namespace HW9_CSharpProfessional.Implementations
{
    /// <summary>
    ///  Класс наследник BicycleBase 
    /// </summary>
    public class Bicycle : BicycleBase, ICloneable
    {
        public string Transmission;
        public string Wheels;
        public string Frame;

        public Bicycle(string Brand, string Type, string transmission, string wheels, string frame) : base(Brand, Type)
        {
            Transmission = transmission;
            Wheels = wheels;
            Frame = frame;
        }

        public override Bicycle MyCloneBicycle()
        {
            return new(Brand, Type, Transmission, Wheels, Frame);
        }

        public override object Clone()
        {
            return MyCloneBicycle();
        }

    }
}
