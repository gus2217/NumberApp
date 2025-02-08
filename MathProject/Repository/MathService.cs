using MathProject.Data;
using MathProject.Interfaces;
using MathProject.Models;
using System;

namespace MathProject.Repository
{
    public class MathService : IMathService
    {
        private readonly MathDbContext _mathDbContext;

        public MathService(MathDbContext mathDbContext)
        {
            _mathDbContext = mathDbContext;
        }
        public int GetDigitSum(int n)
        {
            return n.ToString().Select(d => int.Parse(d.ToString())).Sum();
        }

        public string GetFunFact(int n)
        {
            if (IsArmstrong(n))
                return $"{n} is an Armstrong number because {string.Join(" + ", n.ToString().Select(d => $"{d}^{n.ToString().Length}"))} = {n}";
            return $"{n} is an interesting number!";
        }

        public NumberInfo GetNumber(int num)
        {
            var existingNumber = _mathDbContext.Numbers.FirstOrDefault(n => n.Number == num);
            if (existingNumber != null)
            {
                return existingNumber; // Return cached result
            }

            // Compute properties if not found in DB
            var properties = new List<string>();
            if (IsArmstrong(num)) properties.Add("armstrong");
            if (num % 2 != 0) properties.Add("odd"); else properties.Add("even");

            var newNumberInfo = new NumberInfo
            {
                Number = num,
                IsPrime = IsPrime(num),
                IsPerfect = IsPerfect(num),
                Properties = properties,
                DigitSum = GetDigitSum(num),
                FunFact = GetFunFact(num)
            };

            // Save to database
            _mathDbContext.Numbers.Add(newNumberInfo);
            _mathDbContext.SaveChanges();

            return newNumberInfo;
        }

        public bool IsArmstrong(int n)
        {
            int sum = 0, temp = n, digits = n.ToString().Length;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }
            return sum == n;
        }

        public bool IsPerfect(int n)
        {
            int sum = Enumerable.Range(1, n).Where(x => n % x == 0 && x != n).Sum();
            return sum == n;
        }

        public bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

       
    }
}
