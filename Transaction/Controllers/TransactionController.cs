using Microsoft.AspNetCore.Mvc;
using Transaction.business;
using Transaction.domain;

namespace Transaction.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {

        private readonly TransactionBusiness transactionBusiness = new();
        [HttpGet]
        [Route("GetAll")]
        public List<TransactionDomain> GetAll()
        {
            return transactionBusiness.GetAll();
        }

        [HttpGet("{transactionID}")]
        public TransactionDomain GetById(string transactionID)
        {
            return transactionBusiness.GetById(transactionID);
        }

        [HttpPost]
        [Route("Insert")]
        public int Insert(TransactionDomain transactionDomain)
        {
            return transactionBusiness.Add(transactionDomain);
        }

        [HttpPut]
        [Route("Update")]
        public int Update(TransactionDomain transactionDomain)
        {
            return transactionBusiness.Update(transactionDomain);
        }

        [HttpDelete("{transactionID}")]
        public int Delete(string transactionID)
        {
            return transactionBusiness.Delete(transactionID);
        }
    }
}
