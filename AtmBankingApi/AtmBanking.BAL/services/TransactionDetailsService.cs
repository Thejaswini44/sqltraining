using AtmBanking.DAL.Repository;
using AtmBanking.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.BAL.services
{
   public class TransactionDetailsService
    {
      
        
            private ITransactionDetailsRepository _transactionDetailsRepository;
            public TransactionDetailsService(ITransactionDetailsRepository transactionInfoRepository)
            {
                _transactionDetailsRepository = transactionInfoRepository;
            }

            public void TransactionDetailsEntry(TransactionDetails transactionDetails)
            {
                _transactionDetailsRepository.TransactionDetailsEntry(transactionDetails);
            }
        public IEnumerable<TransactionDetails> GetTransactionDetails()
        {
            return _transactionDetailsRepository.GetTransactionDetails();
        }
    }
    }

