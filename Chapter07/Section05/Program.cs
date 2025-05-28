namespace Section05 {
    internal class Program {
        static void Main(string[] args) {

            var text = "The quick brown fox jumps over the lazy dog";
            var words = text.Split(' ');
            var forth = words.Where(s => s.Length == 4).First();

            var numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
            var index = numbers.FindIndex(n => n < 0);

            
            Console.WriteLine("----------------");
            Console.WriteLine(index);
        }
    }
}
