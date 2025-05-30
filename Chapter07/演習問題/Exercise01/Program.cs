﻿
using System.ComponentModel.DataAnnotations;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];

            Console.WriteLine("7.1.1");
            Exercise1(numbers);

            Console.WriteLine("7.1.2");
            Exercise2(numbers);

            Console.WriteLine("7.1.3");
            Exercise3(numbers);

            Console.WriteLine("7.1.4");
            Exercise4(numbers);

            Console.WriteLine("7.1.5");
            Exercise5(numbers);
        }

        private static void Exercise1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Exercise2(int[] numbers) {

            foreach (var select in numbers.Skip(numbers.Length - 2))
                Console.WriteLine(select);
            
            
        }

        private static void Exercise3(int[] numbers) {

            var number = numbers.Select(n => n.ToString("000")).ToArray();
            foreach(var select in number)
                Console.WriteLine(select);
        }

        private static void Exercise4(int[] numbers) {

            var select = (numbers.OrderBy(n => n)).Take(3);
            foreach(var n in select)

                Console.WriteLine(n);

        }

        private static void Exercise5(int[] numbers) {

            var select = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(select);
        }
    }
}
