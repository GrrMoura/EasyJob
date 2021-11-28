using EasyJob_Business.Core.Model;

namespace EasyJob_Business.Models.Payments
{    public class PayPalPayment : Payment
    {
        public string LastTransactionCode { get; set; }
    }
}
