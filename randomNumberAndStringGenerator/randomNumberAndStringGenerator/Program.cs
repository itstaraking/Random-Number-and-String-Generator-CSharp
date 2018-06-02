using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumberAndStringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumberAndStringGenerator randomGen = new RandomNumberAndStringGenerator();
            Console.WriteLine(randomGen.RandomNumber());
            Console.WriteLine(randomGen.RandomNumber(100));
            Console.WriteLine(randomGen.RandomNumber(50, 100));
            Console.WriteLine(randomGen.RandomString());


            Console.ReadKey();
        }
        // create random generator class
        public class RandomNumberAndStringGenerator
        {
            // create random number function passing it two arguments for minimum and 
            // maximum values
            public int RandomNumber(int minValue = 0, int maxValue = int.MaxValue)
            {
                // create random object
                Random rand = new Random();
                // return random numbers
                return rand.Next(minValue, maxValue);
            }
            // create random string function using string builder giving it a 
            // max length of 5
            public string RandomString(int size = 5)
            {
                // create new string builder object
                StringBuilder sb = new StringBuilder();
                // create new random object
                Random rand = new Random();
                // create char variable to hold individual char in string
                char ch;

                // for loop to iterate 5 times to fill string size
                for(int index = 0; index <size; index++)
                {
                    // converts ch to ascii characters between 65-90
                    ch = Convert.ToChar(rand.Next(65, 90));
                    // adds characters to string builder
                    sb.Append(ch);
                }

                // returns string
                return sb.ToString();
            }
        }
    }
}
