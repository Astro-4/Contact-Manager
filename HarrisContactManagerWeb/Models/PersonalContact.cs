using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManagerWeb.Models
{
    public class PersonalContact
    {
        public int PersonalContactID { set; get; }
        public string PersonalFname{ set; get; }
        public string PersonalLname{ set; get; }
        public string PersonalDepartment{ set; get; }
        public string PersonalTel{ set; get; }
        public string PersonalEmail{ set; get; }
        public string PersonalAddr{ set; get; }
        public string PersonalCity{ set; get; }
        public string PersonalPostcode{ set; get; }
    }
}
