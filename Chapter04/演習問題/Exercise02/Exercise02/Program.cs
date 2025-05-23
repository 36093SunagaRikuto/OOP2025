using System;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1();
            Console.WriteLine("---");
            Exercise2();
            Console.WriteLine("---");
            Exercise3();

        }

        private static void Exercise1() {
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
                Console.WriteLine("あ");
                Console.WriteLine(num);
                
            else if (num < 100)
                Console.WriteLine(num * 2);
            else if (num < 500)
                Console.WriteLine(num * 3);
            else
                Console.WriteLine(num);
        }

        private static void Exercise2() {
            throw new NotImplementedException();
        }

        private static void Exercise3() {
            throw new NotImplementedException();
        }
    }
}
