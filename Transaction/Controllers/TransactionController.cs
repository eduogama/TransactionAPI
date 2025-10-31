using Microsoft.AspNetCore.Mvc;
using Transaction.business;
using Transaction.business.Interface;
using Transaction.domain;

namespace Transaction.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController(ITransactionBusiness transactionBusiness) : Controller
    {
        private readonly ITransactionBusiness _transactionBusiness = transactionBusiness;

        [HttpGet]
        [Route("BuscaTodos")]
        public List<TransactionDomain> GetAll()
        {
            return _transactionBusiness.GetAll();
        }

        [HttpGet("{transactionID}")]
        public TransactionDomain GetById(string transactionID)
        {
            return _transactionBusiness.GetById(transactionID);
        }

        [HttpPost]
        [Route("Insert")]
        public int Insert(TransactionDomain transactionDomain)
        {
            return _transactionBusiness.Add(transactionDomain);
        }

        [HttpPut]
        [Route("Update")]
        public int Update(TransactionDomain transactionDomain)
        {
            return _transactionBusiness.Update(transactionDomain);
        }

        [HttpDelete("{transactionID}")]
        public int Delete(string transactionID)
        {
            return _transactionBusiness.Delete(transactionID);
        }
    }
}
