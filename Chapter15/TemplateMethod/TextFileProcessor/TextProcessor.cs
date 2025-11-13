using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessor {
    public abstract class TextProcessor {

        public static void Run<T>(string fileName) where T : TextProcessor, new() {
            var self = new T();
            self.Process(fileName);

            
        }

        private void Process(string fileName) {
            Initialize(fileName);
            
            var input = Console.ReadLine() ?? "";
            using (var sr = new StreamReader(fileName, Encoding.UTF8)) {

                var line = File.ReadLines(fileName);
                foreach (var lili in line) {
                    if (lili.Contains(input))
                        Execute(lili);
                }
                Terminate();
            }
        }

        protected virtual void Initialize(string fname) { }
        protected virtual void Execute(string line) { }
        protected virtual void Terminate() { }
    }
}
