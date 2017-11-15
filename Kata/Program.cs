using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Training{


        public static string ToBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }

        public static string ToJadenCase(string phrase)
        {
            if (String.IsNullOrEmpty(phrase) || String.IsNullOrWhiteSpace(phrase))
                throw new InvalidExpressionException("Phrase shouldn't be null, empty or whitespace");

            string[] phraseList = phrase.Split(' ');
            var upperCasePhraseList = new List<string>();

            foreach (var word in phraseList)
            {
                upperCasePhraseList.Add(Convert.ToString(word.ToUpper()[0]) + word.Substring(1, word.Length - 1));
            }

            string returnPhrase = String.Join(" ", upperCasePhraseList.ToArray());

            return returnPhrase;
        }

        public static int NaturalNumbers(int number)
        {
            var numbers = new List<int>();

            if (number < 0)
                throw new ArgumentOutOfRangeException("number", "number should be greater than 0");

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    numbers.Add(i);
                }
            }

            return numbers.Sum();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string tester = "moOse";
            Console.WriteLine(tester);
            var test = tester.ToLower();
            Console.WriteLine(test);

            for (var i = 0; i < test.Length; i++)
            {


                for (var j = 0; j < test.Length; j++)
                {
                    if (test[i] == test[j] && i != j)
                    {
                        Console.WriteLine("False " + test[i] + " " + test[j]);
                        break;
                    }
                }
            }
            Console.WriteLine("True");

            string numbers = "2 4 7 8 9";
            string[] numbersList = numbers.Split(' ');
            int even = 0;
            int odd = 0;


            //            foreach (var number in numbersList)
            //            {
            //                int x = Convert.ToInt32(number) % 2;
            //                
            //                if (x == 0)
            //                    even++;
            //                else
            //                    odd++;
            //            }

            System.Console.WriteLine(Training.ToBinary(5, 5));

            Console.WriteLine(Training.NaturalNumbers(10));
            Console.WriteLine(Training.NaturalNumbers(24));

        }

        

        
    }
}
