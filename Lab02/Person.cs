using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal enum Gender
    {
        Unknown, Male, Female
    }

    internal class Person
    {
        public int Age { get => BirthDate != null
                ? new DateTime(DateTime.Now.Subtract((DateTime)BirthDate).Ticks).Year - 1
                : 0;
        }
        public DateTime? BirthDate { get; set; }
        public string FirstName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public Gender Gender { get; set; }
        public string LastName { get; set; }

        public Person() {
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = Gender.Unknown;
        }

        public Person(string firstName, string lastName, DateTime? birthDate, Gender gender = Gender.Unknown)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            Person other = (Person)obj;
            return this.FirstName.Equals(other.FirstName)
                && this.LastName.Equals(other.LastName)
                && this.Gender == other.Gender
                && this.BirthDate == other.BirthDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BirthDate, FirstName, Gender, LastName);
        }

        public override string ToString()
        {
            return $"{FullName} ({Age})";
        }
    }
}
