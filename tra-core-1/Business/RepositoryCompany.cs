using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tra_core_1.Model;

namespace tra_core_1.Business
{
    public class RepositoryCompany : IRepositoryCompany
    {
        private Company company;

        public RepositoryCompany()
        {
            company = new EducationCompany();
            company.Name = "name";
            company.Link = new Link("linkid", "1");
        }

        public Company GetCompany()
        {
            return this.company;
        }
    }
}
