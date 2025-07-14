using Transaction.business.Interface;
using Transaction.domain;
using Transaction.repository.Repository;

namespace Transaction.business
{
    public class TransactionBusiness : ITransactionBusiness
    {
        private readonly TransactionRepository transactionRepository = new();

        public List<TransactionDomain> GetAll()
        {
            return transactionRepository.GetAll();
        }

        public TransactionDomain GetById(string id)
        {
            return transactionRepository.GetById(id);
        }

        public int Add(TransactionDomain entity)
        {
            return transactionRepository.Add(entity);
        }

        public int Update(TransactionDomain entity)
        {
            return transactionRepository.Update(entity);
        }

        public int Delete(string id)
        {
            return transactionRepository.Delete(id);
        }
    }
}
