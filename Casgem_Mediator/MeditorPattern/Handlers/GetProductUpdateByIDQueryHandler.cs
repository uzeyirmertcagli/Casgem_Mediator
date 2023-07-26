using Casgem_Mediator.DAL;
using Casgem_Mediator.MeditorPattern.Queries;
using Casgem_Mediator.MeditorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MeditorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductUpdateByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIDQueryResult
            {
                ProductBrand = values.ProductBrand,
                ProductCategory = values.ProductCategory,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductId = values.ProductId,
                ProductStock = values.ProductStock
            };
        }
    }
}
