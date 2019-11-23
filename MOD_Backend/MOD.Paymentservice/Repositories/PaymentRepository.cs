using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Paymentservice.Context;
using MOD.Paymentservice.Models;

namespace MOD.Paymentservice.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }
        public void Add(Payment item)
        {
            _context.Payments.Add(item);
            _context.SaveChanges();
        }

        public List<Payment> GetPayments()
        {
            return _context.Payments.ToList();
        }

        
    }
}
