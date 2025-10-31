using Transaction.domain;

namespace Transaction.business.Interface
{
    public interface ITransactionBusiness
    {
        public List<TransactionDomain> GetAll();
        public TransactionDomain GetById(string id);
        public int Add(TransactionDomain entity);
        public int Update(TransactionDomain entity);
        public int Delete(string id);

    }
}
