using MediatR;
using StudyingCQRSAndMediator.Models;

namespace StudyingCQRSAndMediator.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
