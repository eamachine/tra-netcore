using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tra_core_1.Model;

namespace tra_core_1.Business
{
    public class RepositoryPerson : IRepositoryPerson
    {
        private Person person;

        public RepositoryPerson()
        {
            var contactInfo = new ContactInfo();
            contactInfo.Email = "correo@correo.co";
            contactInfo.Phone = "123456";
            this.person = new Person(contactInfo);
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
