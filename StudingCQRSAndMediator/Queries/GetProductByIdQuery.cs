using MediatR;
using StudyingCQRSAndMediator.Models;

namespace StudyingCQRSAndMediator.Queries
{
    public record GetProductByIdQuery(int Id): IRequest<Product?>;
}
