using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPIs.Models.RequestsAndResponses
{
    public class InsertSignupInfoParams
    {
        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

        public System.Int64 Phone { get; set; }
    }
}