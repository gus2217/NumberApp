using MathProject.Models;

namespace MathProject.Interfaces
{
    public interface IMathService
    {
        NumberInfo GetNumber(int n);
        bool IsPrime(int n);
        bool IsPerfect(int n);
        int GetDigitSum(int n);
        string GetFunFact(int n);
        bool IsArmstrong(int n);
    }
}
