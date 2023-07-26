namespace Casgem_Mediator.MeditorPattern.Results
{
    public class GetProductUpdateByIDQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
