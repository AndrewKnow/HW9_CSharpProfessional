
namespace HW9_CSharpProfessional.Abstractions
{
    /// <summary>
    /// Дженерик интерфейс для реализации шаблона прототип
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMyCloneable<T>
    {
        T MyCloneBicycle();
    }
}
