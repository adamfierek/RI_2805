using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    internal class MockPersonService : IPersonService
    {
        public IEnumerable<Person> GetAll()
        {
            return new List<Person> 
            {
                new Person {Id = 1, Age=30, Name= "Jan", Surname="Kowalski"},
                new Person {Id = 2, Age=35, Name= "Robert", Surname="Nowak"},
                new Person {Id = 3, Age=25, Name= "Michał", Surname="Andrzejewski"},
                new Person {Id = 4, Age=36, Name= "Anna", Surname="Dziedzic"},
                new Person {Id = 5, Age=32, Name= "Adam", Surname="Fierek"}
            };
        }
    }
}
