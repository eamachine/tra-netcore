using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tra_core_1.Model;

namespace tra_core_1.Repository
{
    public class RepositoryPerson : IRepositoryPerson
    {
        public Person GetPerson()
        {
            var contactInfo = new ContactInfo();
            contactInfo.Email = "correo@correo.co";
            contactInfo.Phone = "123456";
            return new Person(contactInfo);
        }
    }
}
