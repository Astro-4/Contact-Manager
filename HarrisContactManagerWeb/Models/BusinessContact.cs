using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManagerWeb.Models
{
    public class BusinessContact
    {
        public int BusinessContactID { set; get; }
        public string BusinessFname { set; get; }
        public string BusinessLname { set; get; }
        public string BusinessCompany{ set; get; }
        public string BusinessPosition{ set; get; }
        public string BusinessTel { set; get; }
        public string BusinessEmail { set; get; }
        public string BusinessAddr { set; get; }
        public string BusinessCity { set; get; }
        public string BusinessPostcode { set; get; }
    }
}
