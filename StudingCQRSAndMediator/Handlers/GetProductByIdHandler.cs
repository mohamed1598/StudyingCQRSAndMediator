using MediatR;
using StudyingCQRSAndMediator.Data;
using StudyingCQRSAndMediator.Models;
using StudyingCQRSAndMediator.Queries;

namespace StudyingCQRSAndMediator.Handlers
{
    public class GetProductByIdHandler(FakeDataStore _fakeDataStore) : IRequestHandler<GetProductByIdQuery, Product?>
    {
        public async Task<Product?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        => await _fakeDataStore.GetProductById(request.Id);
    }
}
