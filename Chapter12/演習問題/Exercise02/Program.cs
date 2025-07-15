using System.Text.Json;
using System.Text.Json.Serialization;


namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var jsonString = File.ReadAllText("novelist.json");
            var novelist = Deserialize(jsonString);
            if (novelist is not null) {
                Console.WriteLine(novelist);
                foreach (var item in novelist.Masterpieces) {
                    Console.WriteLine(item);
                }
            }
        }

        static Novelist? Deserialize(string filepath) {

            var options = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals |
                                 JsonNumberHandling.AllowReadingFromString

              

            };
            var nove = JsonSerializer.Deserialize<Novelist>(filepath,options);



            return nove;
        }
    }

    public record Novelist {
        public string? Id { get; init; }
        public string Name { get; init; } = string.Empty;
        [JsonPropertyName("birth")]
        public DateTime Birthday { get; init; }
        public string[] Masterpieces { get; init; } = [];
    }
}
