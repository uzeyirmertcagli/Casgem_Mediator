using Casgem_Mediator.DAL;
using Casgem_Mediator.MeditorPattern.Queries;
using Casgem_Mediator.MeditorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MeditorPattern.Handlers
{
    public class ProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        readonly Context _context;

        public ProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetProductQueryResult
            {
                ProductBrand = x.ProductBrand,
                ProductCategory = x.ProductCategory,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductId = x.ProductId,
                ProductStock = x.ProductStock

            }).AsNoTracking().ToListAsync();
        }
    }
}
