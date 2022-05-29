using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
    }

    public interface IPersonServiceAsync
    {
        Task<IEnumerable<Person>> GetAll();
    }
}
