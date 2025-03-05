using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class PersonDatabase
    {
        private HashSet<Person> _people;

        public PersonDatabase()
        {
            _people = [];
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Add(IEnumerable<Person> people)
        {
            foreach (Person person in people)
            {
                _people.Add(person);
            }
        }

        public List<Person> Find(string text, Gender? gender)
        {
            List<Person> result = [];

            foreach (Person person in _people)
            {
                if (gender == null || person.BirthDate == null)
                {
                    continue;
                }

                if ((gender == null || person.Gender == gender)
                    && person.FullName.Contains(text))
                {
                    result.Add(person);
                }
            }

            return result;
        }

        public void PrintToConsole()
        {
            Console.Write("[");
            foreach (Person person in _people)
            {
                Console.Write(person.ToString());
            }
            Console.WriteLine("]");
        }

        public void Remove(Person person)
        {
            _people.Remove(person);
        }
    }
}
