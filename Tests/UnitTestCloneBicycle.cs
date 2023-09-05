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

            cloneBicycly.Brand = "10";
            cloneBicycly.Type = "20";
            cloneBicycly.Transmission = "30";
            cloneBicycly.Wheels = "40";
            cloneBicycly.Frame = "50";

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
            var cloneBicycly = (Bicycle)bicycle.Clone();

            Assert.IsNotNull(cloneBicycly);

            Assert.AreNotSame(bicycle, cloneBicycly);

            Assert.AreEqual(bicycle.Brand, cloneBicycly.Brand);
            Assert.AreEqual(bicycle.Type, cloneBicycly.Type);
            Assert.AreEqual(bicycle.Transmission, cloneBicycly.Transmission);
            Assert.AreEqual(bicycle.Wheels, cloneBicycly.Wheels);
            Assert.AreEqual(bicycle.Frame, cloneBicycly.Frame);

            cloneBicycly.Brand = "10";
            cloneBicycly.Type = "20";
            cloneBicycly.Transmission = "30";
            cloneBicycly.Wheels = "40";
            cloneBicycly.Frame = "50";

            Assert.AreNotEqual(bicycle.Brand, cloneBicycly.Brand);
            Assert.AreNotEqual(bicycle.Type, cloneBicycly.Type);
            Assert.AreNotEqual(bicycle.Transmission, cloneBicycly.Transmission);
            Assert.AreNotEqual(bicycle.Wheels, cloneBicycly.Wheels);
            Assert.AreNotEqual(bicycle.Frame, cloneBicycly.Frame);
        }
    }
}