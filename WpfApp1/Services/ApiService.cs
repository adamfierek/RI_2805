using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    internal class ApiService : IPersonServiceAsync
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions serialezerOptions;

        public ApiService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000");
            serialezerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            //POST example:
            //var person = new Person()
            //{
            //    Name = "Jan",
            //    Surname = "Kowalski",
            //    Age = 30
            //};

            //var json = JsonSerializer.Serialize(person, serialezerOptions);


            //await client.PostAsync("api/person", new StringContent(json));

            

            var result = await client.GetAsync("api/person/getall");
            if (!result.IsSuccessStatusCode) return new List<Person>();

            var content = await result.Content.ReadAsStringAsync();

            var list = JsonSerializer.Deserialize<List<Person>>(content, serialezerOptions);

            if (list is not null) return list;

            return new List<Person>();
        }
    }
}
