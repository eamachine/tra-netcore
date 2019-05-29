using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tra_core_1.Model
{
    public class EducationCompany : Company
    {

        public EducationCompany()
        {
            this.Type = CompanyType.Education;
        }

        public override string GetCompanyInfo()
        {
            return this.Name + this.CompanyTypeTxt + this.Link;
        }
    }
}
