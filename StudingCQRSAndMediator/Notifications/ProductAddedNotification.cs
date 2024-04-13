using MediatR;
using StudyingCQRSAndMediator.Models;

namespace StudyingCQRSAndMediator.Notifications
{
    public record ProductAddedNotification(Product Product):INotification;
}
