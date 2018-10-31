using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0, number2 = 2;
            int maxElement;
            int minElement;
            int length;
            Console.Write("Введите махималный элемент рандома:");
            maxElement= Int32.Parse(Console.ReadLine());
            Console.Write("Введите минималный элемент рандома:");
            minElement = Int32.Parse(Console.ReadLine());
            Console.Write("Введите длина массива:");
            length = Int32.Parse(Console.ReadLine());
            List<int> box = new List<int>(length);

            Random random = new Random();

            int sum = number1, max, index;

            for (int i = number1; i < box.Capacity; i++)
            {
                box.Add(random.Next(minElement, maxElement));
                Console.Write(box[i] + " ");
                if (i % number2 == number1)
                    sum += box[i];
            }
            max = box.Max();
            index = box.IndexOf(max);
            int secondMax = number1;
            for (int i = number1; i < box.Count; i++)
            {
                if (i != max && box[i] != box[index] && box[i] > box[secondMax])
                {
                    secondMax = i;
                }
            }
            index = box.IndexOf(secondMax);
            Console.WriteLine("\nВторое максимальное значение:  " + box[secondMax]);
            Console.WriteLine("\nИндекс второго максимального значение: " + secondMax);
            Console.WriteLine("\nСумма  всех чисел на четных позициях: " + sum);
            Console.ReadLine();
        }
    }
}
