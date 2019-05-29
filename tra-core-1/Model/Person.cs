using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tra_core_1.Model
{
    public class Person
    {
        public ContactInfo contactInfo { get; set; }

        public Person (ContactInfo contactInfo)
        {
            this.contactInfo = contactInfo;
        }
    }
}
