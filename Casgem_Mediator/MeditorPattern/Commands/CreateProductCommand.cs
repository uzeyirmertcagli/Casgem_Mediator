using MediatR;

namespace Casgem_Mediator.MeditorPattern.Commands
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
