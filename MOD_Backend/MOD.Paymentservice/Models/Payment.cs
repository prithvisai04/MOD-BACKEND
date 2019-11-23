using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Paymentservice.Models
{
    public class Payment
    {
        public string PaymentId { get; set; }
        [ForeignKey("User")]
        public string UId { get; set; }
        [ForeignKey("Training")]
        public string TrainingId { get; set; }
        public int Amount { get; set; }
        [ForeignKey("Mentor")]
        public string Mentorid { get; set; }

        public int Mentor_Amount { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Trainings Training { get; set; }
    }
}
