using Ledger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ledger.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private static List<Transaction> Transactions => new List<Transaction>
        {
            new Transaction
            {
                ProductId = Guid.Parse("ef29fc61-abcc-4ac1-9c8c-e5e17b266868"),
                UserId = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111"),
                OccuredAt = DateTime.Now,
                PriceAtPointInTime = 36,
                Quantity = 5,
                Total = 180
            },
            new Transaction
            {
                ProductId = Guid.Parse("d91d2019-e642-4b00-8b10-2bf07c383787"),
                UserId = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f"),
                OccuredAt = DateTime.Now,
                PriceAtPointInTime = 36,
                Quantity = 5,
                Total = 180
            }
        };

        [HttpGet]
        public List<Transaction> All()
        {
            return Transactions;
        }

        [HttpGet("/api/transaction/getbyuserid/{id}")]
        public List<Transaction> GetByUserId(Guid? id)
        {
            return Transactions.Where(t => t.UserId == id)
                .ToList();
        }
    }
}