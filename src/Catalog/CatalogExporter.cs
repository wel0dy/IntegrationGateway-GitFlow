namespace Gateway.Catalog
{
    /// <summary>Выгрузка карточек товаров на маркетплейс.</summary>
    public class CatalogExporter
    {
        public bool CanExport(string sku, string title, decimal price) =>
            !string.IsNullOrWhiteSpace(sku) && !string.IsNullOrWhiteSpace(title) && price > 0;
    }
}
