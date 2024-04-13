using MediatR;
using StudyingCQRSAndMediator.Commands;
using StudyingCQRSAndMediator.Data;
using StudyingCQRSAndMediator.Models;

namespace StudyingCQRSAndMediator.Handlers
{
    public class AddProductHandler(FakeDataStore fakeDataStore) : IRequestHandler<AddProductCommand,Product>
    {
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await fakeDataStore.AddProduct(request.Product);
            return request.Product;
        }
    }
}
