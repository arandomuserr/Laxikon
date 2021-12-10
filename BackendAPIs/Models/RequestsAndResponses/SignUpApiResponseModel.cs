using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPIs.Models.RequestsAndResponses
{
    public class SignUpApiResponseModel
    {
        public string Password { get; set; }

        public bool Status { get; set; }
    }
}