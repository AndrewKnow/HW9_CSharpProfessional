
using HW9_CSharpProfessional.Implementations;

namespace HW9_CSharpProfessional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMyCloneable позволяет указывать какую копию объекта необходимо создать. " +
                "Microsoft не рекомендует использовать ICloneable, поскольку в интерфейсе нет четкого указания как клонирование выполнять глубокое или поверхностное.");
            Console.ReadKey();
        }
    }
}