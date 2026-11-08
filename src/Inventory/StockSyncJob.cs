namespace Gateway.Inventory
{
    /// <summary>Выгрузка складских остатков на витрину каждые 5 минут.</summary>
    public class StockSyncJob
    {
        public static readonly TimeSpan Interval = TimeSpan.FromMinutes(5);

        public int AvailableToSell(int onHand, int reserved) => Math.Max(0, onHand - reserved);

        /// <summary>При отмене заказа резерв возвращается в остаток.</summary>
        public int ReleaseReserve(int reserved, int cancelled) => Math.Max(0, reserved - cancelled);
    }
}
