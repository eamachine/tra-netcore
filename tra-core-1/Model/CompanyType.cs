using System.ComponentModel;

namespace tra_core_1.Model
{
    public enum CompanyType
    {
        [Description("Education")]
        Education,
        [Description("Small Company")]
        Starup,
        [Description("Big Company")]
        BigCompany
    }
}