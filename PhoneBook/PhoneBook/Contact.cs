using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        public int CID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Steet { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string ContactRelation { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
    }
}
