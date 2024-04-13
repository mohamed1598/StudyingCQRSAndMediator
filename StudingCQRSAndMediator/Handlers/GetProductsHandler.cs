using MediatR;
using StudyingCQRSAndMediator.Data;
using StudyingCQRSAndMediator.Models;
using StudyingCQRSAndMediator.Queries;

namespace StudyingCQRSAndMediator.Handlers
{
    public class GetProductsHandler(FakeDataStore fakeDataStore) : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore=fakeDataStore;
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        => await _fakeDataStore.GetAllProducts();
    }
}
