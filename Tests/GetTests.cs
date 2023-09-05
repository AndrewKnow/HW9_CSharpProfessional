using HW9_CSharpProfessional.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class GetTests
    {
        public Bicycle GetBicycle()
        {
            return new Bicycle("Школьник", "Детский", "Зубчатая", "16", "Открытая");
        }
    }
}
