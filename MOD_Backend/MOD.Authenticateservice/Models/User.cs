using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Models
{
    public class User
    {
        [Key]
        public string UId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [StringLength(10)]
        public string MobileNo { get; set; }
        [Required]
        public string Password { get; set; }

        public bool Active { get; set; }
    }
}
