using AtmBanking.DAL.Data;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
     public class TransactionDetailsRepository :ITransactionDetailsRepository
    {
        private AtmDbContext _atmDbContext;
        public TransactionDetailsRepository(AtmDbContext atmDbContext)
        {
            _atmDbContext = atmDbContext;
        }
        public void TransactionDetailsEntry(TransactionDetails transactionDetails)
        {
            _atmDbContext.transactionDetails.Add(transactionDetails);
            _atmDbContext.SaveChanges();
        }
    }
}
