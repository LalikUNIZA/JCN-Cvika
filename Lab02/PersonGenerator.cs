using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal static class PersonGenerator
    {
        public static Person[] Generate(int count)
        {
            string[] firstNamesM = ["Ján", "Alexander", "Adam", "Juraj", "Štefan"];
            string[] lastNamesM = ["Nový", "Malý", "Veľký", "Chudý", "Vysoký", "Bohatý", "Krásny"];
            string[] firstNamesF = ["Silvia", "Františka", "Michaela", "Barbora", "Eva"];
            string[] lastNamesF = ["Nová", "Malá", "Veľká", "Chudá", "Vysoká", "Bohatá", "Krásna"];
            string[] firstNamesU = firstNamesM.Concat(firstNamesF).ToArray();
            string[] lastNamesU = lastNamesM.Concat(lastNamesF).ToArray();

            Array<Person> result = [];

            for (int i = 0; i < count; ++i)
            {
                int random = Random.Shared.Next(3);
                Gender gender;
                string firstName;
                string lastName;
                switch (random)
                {
                    case 0:
                        gender = Gender.Male;
                        firstName = firstNamesM[Random.Shared.Next(firstNamesM.Length)];
                        lastName = lastNamesM[Random.Shared.Next(lastNamesM.Length)];
                        break;
                    case 1:
                        gender = Gender.Female;
                        firstName = firstNamesF[Random.Shared.Next(firstNamesF.Length)];
                        lastName = lastNamesF[Random.Shared.Next(lastNamesF.Length)];
                        break;
                    default:
                        gender = Gender.Unknown;
                        firstName = firstNamesU[Random.Shared.Next(firstNamesU.Length)];
                        lastName = lastNamesU[Random.Shared.Next(lastNamesU.Length)];
                        break;
                }

                DateTime start = new(1950, 1, 1);
                int range = (DateTime.Today - start).Days;
                DateTime birthDate = start.AddDays(Random.Shared.Next(range));

                Person person = new(firstName, lastName, birthDate, gender);
                Console.WriteLine(person.ToString());
                _ = result.Append(person);
                Console.WriteLine(result.Count);
            }

            return result.ToArray();
        }
    }
}
