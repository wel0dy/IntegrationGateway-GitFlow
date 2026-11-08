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
