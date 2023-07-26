using Casgem_Mediator.DAL;
using Casgem_Mediator.MeditorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MeditorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductId);
            values.ProductBrand = request.ProductBrand;
            values.ProductPrice = request.ProductPrice;
            values.ProductStock = request.ProductStock;
            values.ProductCategory = request.ProductCategory;
            values.ProductName = request.ProductName;
            await _context.SaveChangesAsync();
            return Unit.Value;

        }
    }
}
