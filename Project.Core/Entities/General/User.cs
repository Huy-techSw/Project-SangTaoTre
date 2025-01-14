using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities.General
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Role {  get; set; }
        public string ImageId {  get; set; }
        public string OTPVerified { get; set; }
        public string Status { get; set; }
    }
}
