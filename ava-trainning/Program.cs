using System;
using System.Globalization;
namespace Avanade.Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 0;
            double salaryIncrease = 0;
            double increase = 0.10;
            string employee;

            Console.WriteLine("Digite o nome do funcionário: ");
            employee = Console.ReadLine();

            Console.WriteLine("Entre com o salário do funcionário: R$ ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O salário inicial do(a) funcionário(a) {employee} é R$ {salary.ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            salaryIncrease = salary + (salary * increase);

            Console.WriteLine($"Com o aumento de {increase * 100}% o salário passa a ser R$ {salaryIncrease.ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            Console.WriteLine($"O valor do aumento foi R$ {(salaryIncrease - salary).ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            Console.ReadLine();
        }
    }
}