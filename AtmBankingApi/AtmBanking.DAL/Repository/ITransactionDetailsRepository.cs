using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Repository
{
   public interface ITransactionDetailsRepository
    {
        void TransactionDetailsEntry(TransactionDetails transactionDetails);
    }
}
