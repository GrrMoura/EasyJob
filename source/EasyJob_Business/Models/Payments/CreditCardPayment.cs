using EasyJob_Business.Core.Model;

namespace EasyJob_Business.Models.Payments
{
    public class CreditCardPayment:Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }

        public string LastTransactionNumber { get; set; }// ver o número da transação e adicionar + 1 na próxima
    }
}
