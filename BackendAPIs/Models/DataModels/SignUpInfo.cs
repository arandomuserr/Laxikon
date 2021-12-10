using System.ComponentModel.DataAnnotations;

namespace BackendAPIs.DataModels
{
    public class SignUpInfo
    {
        [Key]
        public int Id { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

        public System.Int64 Phone { get; set; }

        public bool? IsUserRegistered { get; set; }
    }
}