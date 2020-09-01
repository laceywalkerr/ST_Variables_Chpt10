using System;

namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        //**************** C# is Strongly Typed *************//

        string name = "Julio";
        int num = 42;
        List<bool> boolList = new List<bool>();
        double percentage = 0.99;

        //**************** Types All the Way Down *************//
        Dictionary<string, int> bowlingScores = new Dictionary<string, int>();

        bowlingScores.Add("Marvin", 80);
        bowlingScores.Add("Denise", 290);
        bowlingScores.Add("Alef", 220);
        bowlingScores.Add("Wilma", 200);

        //**************** Custom Types *************//
        {
            Dog rusty = new Dog()
            {
                Breed = "mut",
                Name = "Rusty",
                Age = 10,
                hasShots = true
            };

            Console.WriteLine(rusty.Name);
        }

        public class Dog
        {
            public string Breed { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool hasShots { get; set; }
        }
    }
}