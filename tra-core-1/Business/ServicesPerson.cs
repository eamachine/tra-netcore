using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tra_core_1.Model;
using tra_core_1.Repository;

namespace tra_core_1.Business
{
    public class ServicesPerson : IServicesPerson
    {
        private Person person;
        private IRepositoryPerson repository;

        public ServicesPerson(IRepositoryPerson repository)
        {
            this.repository = repository;
            GetRepositoryPerson();
        }

        private void GetRepositoryPerson()
        {
            this.person = repository.GetPerson();
        }

        public ContactInfo GetContactInfo()
        {
            return person.contactInfo;
        }

        public Person GetPerson()
        {
            return person;
        }

        public bool IsContactable()
        {
            return !String.IsNullOrEmpty(person.contactInfo.Email) || !String.IsNullOrEmpty(person.contactInfo.Phone);
        }
    }
}
