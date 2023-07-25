using Casgem_Mediator.MeditorPattern.Results;
using MediatR;
using System.Collections.Generic;

namespace Casgem_Mediator.MeditorPattern.Queries
{
    public class GetProductQuery:IRequest<List<GetProductQueryResult>>
    {
    }
}
