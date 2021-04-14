using System;
using System.Linq;

namespace LanguageReview {
    class Program {
        void RoundingScores() {
            var scores = new int[] { 4, 73, 67, 38, 33 };
            var rounded = new int[5];
            for(var idx = 0; idx < scores.Length; idx++) {
                rounded[idx] = scores[idx];
                if(scores[idx] < 38) continue;
                var inc = 0;
                while((scores[idx] + inc) % 5 != 0) {
                    inc++;
                }
                if(inc <= 2) {
                    rounded[idx] += inc;
                }
            }
        }
        void Sum1To50IfDivisibleBy5Or7() {
            int sum = 0;
            for(int idx = 1; idx <= 50; idx++) {
                if(idx % 5 == 0 || idx % 7 == 0)
                    sum += idx;
            }
            Console.WriteLine($"{sum}");
            Console.ReadKey();
        }
        void MinMax4Of5Numbers() {
            var ints = new int[] { 1, 3, 5, 7, 9 };
            var min = ints.Sum() - ints.Max();
            var max = ints.Sum() - ints.Min();
            Console.WriteLine($"{min} {max}");
            Console.ReadKey();
        }
        void run() {
            RoundingScores();
        }
        static void Main(string[] args) {
            (new Program()).run();
        }
    }
}
