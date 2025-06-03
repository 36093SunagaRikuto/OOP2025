namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            //var usi = Console.ReadLine();

            if(int.TryParse(Console.ReadLine(), out var num)) {
                Console.WriteLine("iketa");

            } else {
                Console.WriteLine("dameda");

            }
        }
    }
}
