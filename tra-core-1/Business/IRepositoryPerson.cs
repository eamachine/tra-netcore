using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tra_core_1.Model;

namespace tra_core_1.Business
{
    public interface IRepositoryPerson : IContactable
    {
        Person GetPerson();
    }
}
