using Transaction.domain;
using Transaction.repository.Interface;
using Transaction.repository.Queries;

namespace Transaction.repository.Repository
{
    public class TransactionRepository(ISqlRepository repository) : ITransactionRepository
    {
        private readonly ISqlRepository repository = repository;

        public List<TransactionDomain> GetAll()
        {
            try
            {
                return repository.GetAll<TransactionDomain>(TransactionQueries.GetAll, null);
            }
            catch
            {
                throw;
            }
        }

        public TransactionDomain GetById(string id)
        {
            try
            {
                return repository.GetById<TransactionDomain>(TransactionQueries.GetById, id);
            }
            catch
            {
                throw;
            }
        }

        public int Add(TransactionDomain entity)
        {
            try
            {
                return repository.Insert(TransactionQueries.Add, entity);
            }
            catch
            {
                throw;
            }
        }

        public int Update(TransactionDomain entity)
        {
            try
            {
                return repository.Update(TransactionQueries.Update, entity);
            }
            catch
            {
                throw;
            }
        }

        public int Delete(string id)
        {
            try
            {
                return repository.Delete(TransactionQueries.Delete, id);
            }
            catch
            {
                throw;
            }
        }
    }
}
