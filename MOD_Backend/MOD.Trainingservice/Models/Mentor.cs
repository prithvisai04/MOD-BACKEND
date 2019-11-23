using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Trainingservice.Models
{
    public class Mentor
    {
        [Key]
        public string Mentorid { get; set; }
        [Required]
        public string Mentorname { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Experience { get; set; }
        [Required]
        public string Skills { get; set;}
        [Required]
        public string timeslot { get; set; }

        public bool availability { get; set; }

        public bool Active { get; set; }
        public IEnumerable<Trainings> Training { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
