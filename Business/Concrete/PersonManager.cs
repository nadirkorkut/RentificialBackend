using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            _personDal.Delete(person);
        }

        public List<Person> GetList()
        {
            return _personDal.GetList().ToList();
        }

        [CacheAspect(duration:1)]
        public Person GetPersonById(int id)
        {
            return _personDal.Get(p => p.Id == id);
        }

        public void Update(Person person)
        {
            _personDal.Update(person);
        }
    }
}
