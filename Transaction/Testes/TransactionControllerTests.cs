using Transaction.Controllers;
using Transaction.domain;
using Xunit;

namespace Transaction.Testes
{
    public class TransactionControllerTests
    {
        [Fact]
        public void GetAll_ReturnsListOfTransactions()
        {
            // Arrange
            var controller = new TransactionController();

            // Act
            var result = controller.GetAll();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<TransactionDomain>>(result);
        }

        [Fact]
        public void GetById_ReturnsSingleTransaction()
        {
            // Arrange
            var controller = new TransactionController();
            var id = "123";

            // Act
            var result = controller.GetById(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.AccountID);
        }

        [Fact]
        public void Insert_ReturnsNewTransactionId()
        {
            // Arrange
            var controller = new TransactionController();
            var transaction = new TransactionDomain { AccountID = "E9525730529761877", TransactionID = "7LF834E4-BLWQ-FJ92-YEYA-85AF05RI2PCX" };

            // Act
            var result = controller.Insert(transaction);

            // Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void Update_ReturnsAffectedRows()
        {
            // Arrange
            var controller = new TransactionController();
            var transaction = new TransactionDomain { AccountID = "E9525730529761877", TransactionID = "7LF834E4-BLWQ-FJ92-YEYA-85AF05RI2PCX" };

            // Act
            var result = controller.Update(transaction);

            // Assert
            Assert.True(result >= 0);
        }

        [Fact]
        public void Delete_ReturnsAffectedRows()
        {
            // Arrange
            var controller = new TransactionController();
            var id = "123";

            // Act
            var result = controller.Delete(id);

            // Assert
            Assert.True(result >= 0);
        }
    }

}
