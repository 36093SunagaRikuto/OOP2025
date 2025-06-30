namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;
        
        

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);
        }
           



        

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

            
            List<Student> students = new List<Student>();
            
            string[] lines = File.ReadAllLines(filePath);
            
            foreach (var line in lines) {
                string[] items = line.Split(',');
                
                Student student = new Student() {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };

                students.Add(student);
            }
            return students;



        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new SortedDictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Name))
                    dict[student.Name] += student.Score;
                else
                    dict[student.Name] += student.Score;

            }
            return dict;




        }
    }
}
