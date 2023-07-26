using MediatR;

namespace Casgem_Mediator.MeditorPattern.Commands
{
    public class UpdateProductCommand : IRequest
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
