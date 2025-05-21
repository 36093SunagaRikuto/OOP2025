using System.Runtime.InteropServices;

namespace Ramda {
    internal class Program {
        static void Main(string[] args) {

            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong kong",
            };

            var exists = cities.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);

            var name = cities.Find(s => s.Length == 6);
            Console.WriteLine(name);

            int index = cities.FindIndex(s => s == "Berlin");
            Console.WriteLine(index);

            var names = cities.FindAll(s => s.Length <= 5);
            foreach(var s in names) {
                Console.WriteLine(s);
            }

            var removedCount = cities.RemoveAll(s => s.Contains("on"));
            Console.WriteLine(removedCount);
        }
    }
}
