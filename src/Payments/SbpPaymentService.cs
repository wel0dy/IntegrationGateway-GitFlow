namespace Gateway.Payments
{
    /// <summary>Оплата заказа через Систему быстрых платежей.</summary>
    public class SbpPaymentService
    {
        public string CreatePayment(string orderId, decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть больше нуля");
            return $"sbp-{orderId}-{DateTime.UtcNow:yyyyMMddHHmmss}";
        }
    }
}

namespace Gateway.Payments
{
    /// <summary>Возврат платежа покупателю.</summary>
    public class RefundService
    {
        public bool CanRefund(decimal paid, decimal refund) => refund > 0 && refund <= paid;
    }
}
