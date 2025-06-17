namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;
        
        

        // コンストラクタ
        public ScoreCounter(string filePath) {

            var counter = File.ReadLines(filePath);
            _score = counter
                .Select(x => x.Split(','))
                .ToList(x => x[0], x => x[1], x => x[2]);
           



        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

           // _score = filePath;

           // return rec;



        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            




        }
    }
}
