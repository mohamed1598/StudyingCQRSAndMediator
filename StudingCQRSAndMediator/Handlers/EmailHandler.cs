using MediatR;
using StudyingCQRSAndMediator.Data;
using StudyingCQRSAndMediator.Notifications;

namespace StudyingCQRSAndMediator.Handlers
{
    public class EmailHandler(FakeDataStore _fakeDataStore) : INotificationHandler<ProductAddedNotification>
    {
        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccurred(notification.Product, "Email Sent");
            await Task.CompletedTask;
        }
    }
}
