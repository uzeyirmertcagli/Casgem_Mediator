using Casgem_Mediator.MeditorPattern.Results;
using MediatR;

namespace Casgem_Mediator.MeditorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<GetProductUpdateByIDQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
