using Casgem_Mediator.DAL;
using Casgem_Mediator.MeditorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MeditorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.Name,
                ProductStock = request.Stock,
                ProductBrand = "Bilinmiyor",
                ProductPrice = 0
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
