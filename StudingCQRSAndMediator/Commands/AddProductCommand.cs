using MediatR;
using StudyingCQRSAndMediator.Models;

namespace StudyingCQRSAndMediator.Commands
{
    public record AddProductCommand(Product Product):IRequest<Product>
    {
    }
}
