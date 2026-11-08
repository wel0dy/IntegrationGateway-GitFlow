namespace Gateway.Payments
{
    /// <summary>Обработка уведомлений платежного шлюза об оплате.</summary>
    public class PaymentCallbackHandler
    {
        private readonly HashSet<string> _processed = new();

        /// <summary>Повторное уведомление с тем же номером платежа не создает второй платеж.</summary>
        public bool Handle(string paymentId) => _processed.Add(paymentId);
    }
}
