using DevIn.Business.Notifications;

namespace DevIn.Business.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void AddNotification(Notification notification);
    }
}
