using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Technologyservice.Models
{
    public class Trainings
    {
        [Key]
        public string TrainingID { get; set; }
        [Required]
        [ForeignKey("User")]
        public string UID { get; set; }
        [Required]
        [ForeignKey("Mentor")]
        public string Mentorid { get; set; }
        [Required]
        [ForeignKey("Skill")]
        public string SkillID { get; set; }
        [Required]
        [Column(TypeName="Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public string timeslot { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public string Progress { get; set; }
        [Required]
        public float rating { get; set; }

        public User User { get; set; }
        public Mentor Mentor { get; set; }

        public Skill Skill { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
        
    }
}
