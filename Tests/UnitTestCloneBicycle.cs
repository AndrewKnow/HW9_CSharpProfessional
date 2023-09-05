using HW9_CSharpProfessional.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass]
    public class UnitTestCloneBicycle: GetTests
    {
        [TestMethod]
        public void TestMyCloneBicycle()
        {
            var bicycle = GetBicycle();
            var cloneBicycly = bicycle.MyCloneBicycle();

            Assert.IsNotNull(cloneBicycly);

            Assert.AreNotSame(bicycle, cloneBicycly);

            Assert.AreEqual(bicycle.Brand, cloneBicycly.Brand);
            Assert.AreEqual(bicycle.Type, cloneBicycly.Type);
            Assert.AreEqual(bicycle.Transmission, cloneBicycly.Transmission);
            Assert.AreEqual(bicycle.Wheels, cloneBicycly.Wheels);
            Assert.AreEqual(bicycle.Frame, cloneBicycly.Frame);

            cloneBicycly.Brand = "Кама";
            cloneBicycly.Type = "Взрослый";
            cloneBicycly.Transmission = "Гидравлическая";
            cloneBicycly.Wheels = "14";
            cloneBicycly.Frame = "Алюминевая";

            Assert.AreNotEqual(bicycle.Brand, cloneBicycly.Brand);
            Assert.AreNotEqual(bicycle.Type, cloneBicycly.Type);
            Assert.AreNotEqual(bicycle.Transmission, cloneBicycly.Transmission);
            Assert.AreNotEqual(bicycle.Wheels, cloneBicycly.Wheels);
            Assert.AreNotEqual(bicycle.Frame, cloneBicycly.Frame);
        }

        [TestMethod]
        public void TestCloneBicycle()
        {
            var bicycle = GetBicycle();
            var cloneBicycly = bicycle.Clone();

            Assert.IsNotNull(cloneBicycly);

            Assert.AreNotSame(bicycle, cloneBicycly);

            Assert.AreEqual(bicycle.Brand, cloneBicycly.Brand);
            Assert.AreEqual(bicycle.Type, cloneBicycly.Type);
            Assert.AreEqual(bicycle.Transmission, cloneBicycly.Transmission);
            Assert.AreEqual(bicycle.Wheels, cloneBicycly.Wheels);
            Assert.AreEqual(bicycle.Frame, cloneBicycly.Frame);

            cloneBicycly.Brand = "Кама";
            cloneBicycly.Type = "Взрослый";
            cloneBicycly.Transmission = "Гидравлическая";
            cloneBicycly.Wheels = "14";
            cloneBicycly.Frame = "Алюминевая";

            Assert.AreNotEqual(bicycle.Brand, cloneBicycly.Brand);
            Assert.AreNotEqual(bicycle.Type, cloneBicycly.Type);
            Assert.AreNotEqual(bicycle.Transmission, cloneBicycly.Transmission);
            Assert.AreNotEqual(bicycle.Wheels, cloneBicycly.Wheels);
            Assert.AreNotEqual(bicycle.Frame, cloneBicycly.Frame);
        }
    }
}