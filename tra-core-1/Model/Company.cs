using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tra_core_1.Model
{
    public abstract class Company
    {
        public String Name { get; set; }

        public Link Link { get; set; }

        public CompanyType Type { private get; set; }

        public String CompanyTypeTxt { get { return Enum.GetName(typeof(CompanyType), Type); } }

        public abstract String GetCompanyInfo();

    }
}
