using Models;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    public class PersonService
    {
        private readonly List<Person> personList;

        public PersonService()
        {
            personList = new List<Person>
            {
                new Person {Id = 1, Age=30, Name= "Jan", Surname="Kowalski"},
                new Person {Id = 2, Age=35, Name= "Robert", Surname="Nowak"},
                new Person {Id = 3, Age=25, Name= "Michał", Surname="Andrzejewski"},
                new Person {Id = 4, Age=36, Name= "Anna", Surname="Dziedzic"},
                new Person {Id = 5, Age=32, Name= "Adam", Surname="Fierek"}
            };
        }

        public IEnumerable<Person> GetAll()
        {
            return personList;
        }

        public void Add(Person person)
        {
            personList.Add(person);
        }
    }
}
