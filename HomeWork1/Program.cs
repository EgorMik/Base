using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, сумму цифр которого необходимо найти: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int absInputNumber = Math.Abs(inputNumber);
            int summ = 0;

            while (absInputNumber > 0)
            {
                summ = summ + absInputNumber % 10;
                absInputNumber = absInputNumber / 10;
            }
            Console.WriteLine($"Сумма цифр введенного числа равна: {summ}");
            Console.ReadKey();
        }
    }
}
