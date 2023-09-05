
namespace HW9_CSharpProfessional.Abstractions
{
    /// <summary>
    /// Родительский класс
    /// </summary>
    public class BicycleBase: IMyCloneable<BicycleBase>, ICloneable
    {
        public string Brand { get; set; }
        public string Type { get; set; }

        public BicycleBase(string brand, string type)
        {
            Brand = brand;
            Type = type;
        }

        public virtual BicycleBase MyCloneBicycle()
        {
            return new BicycleBase(Brand, Type);
        }

        public virtual object Clone()
        {
            return MyCloneBicycle();
        }
    }
}
