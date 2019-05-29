using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tra_core_1.Model
{
    public struct Link
    {
        private String urn, idlink;

        public Link(string urn, string idlink)
        {
            this.urn = urn;
            this.idlink = idlink;
        }

        public String LinkName { get {
            return urn + idlink;
            }
        }
        
    }
}
