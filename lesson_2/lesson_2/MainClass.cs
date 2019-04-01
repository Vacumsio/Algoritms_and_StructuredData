using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
2.Реализовать функцию возведения числа a в степень b:
    a.Без рекурсии.
    b.Рекурсивно.
    c.*Рекурсивно, используя свойство чётности степени.
3.**Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У исполнителя две команды, каждой присвоен номер: 
    1. Прибавь 1.
    2. Умножь на 2.
Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза. Определить, сколько существует программ, которые преобразуют число 3 в число 20:
    а. С использованием массива.
    b. *С использованием рекурсии.
      */
namespace lesson_2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int num = 0;
            ChangeNumber ob = new ChangeNumber();
            Console.Write("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
            string s = ChangeNumber.IntToBin(num);
            Console.WriteLine("Ваше число в двоичной системе: {0}", s);
            Console.ReadKey();
            NumPaw pw = new NumPaw();
            double q = pw.Paw();
            Console.WriteLine("Ваше число {0}",q);
            Console.ReadKey();
        }
    }
}
