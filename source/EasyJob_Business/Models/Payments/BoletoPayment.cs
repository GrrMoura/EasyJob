using EasyJob_Business.Core.Model;

namespace EasyJob_Business.Models.Payments
{
    public class BoletoPayment:Payment
    {
        public string BarCode { get; set; }

    }
}
