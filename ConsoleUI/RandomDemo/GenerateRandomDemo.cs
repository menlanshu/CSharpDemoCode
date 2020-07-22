using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class GenerateRandomDemo
    {

        // You can give a seed value to random
        // Random random = new Random(1);

        public static void RandomizeNumber()
        {
            // Only do random initialization once
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }

        }
        public static void RandomizeNumber_WithLimitSetting()
        {
            // Only do random initialization once
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                // Generate number that 5 <= number <11
                Console.WriteLine(random.Next(5, 11));
            }

        }
        public static void RandomizeNumber_Double()
        {
            // Only do random initialization once
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                // [0, 1)
                Console.WriteLine(random.NextDouble()*10);
            }

        }

        public static void RandomPersonModel()
        {
            Random random = new Random();

            List<PersonModel> people = new List<PersonModel>()
            {
                new PersonModel{FirstName = "Fu"},
                new PersonModel{FirstName = "Zhao"},
                new PersonModel{FirstName = "Qian"},
                new PersonModel{FirstName = "Sun"},
                new PersonModel{FirstName = "Li"},
                new PersonModel{FirstName = "Zhou"},
                new PersonModel{FirstName = "Wu"},
                new PersonModel{FirstName = "Zhen"},
                new PersonModel{FirstName = "Wang"}
            };

            //var sortedPeople = people.OrderBy(x => x.FirstName);
            var sortedPeople = people.OrderBy(x => random.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
        }
    }
}
