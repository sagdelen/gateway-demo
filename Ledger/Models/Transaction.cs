using System;

namespace Ledger.Models
{
    public class Transaction
    {
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public double PriceAtPointInTime { get; set; }

        public DateTime OccuredAt { get; set; }

        public double Quantity { get; set; }

        public double Total { get; set; }
    }
}