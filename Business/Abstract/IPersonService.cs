using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetList();
        Person GetPersonById(int id);
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);
    }
}
