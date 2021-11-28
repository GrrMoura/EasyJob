using System.Collections.Generic;

namespace EasyJob_Business.Core.NotificationsErrors

{
    public interface INotifier
    {
        bool HaveNotification();
        List<ErrorNotification> GetNotifications();
        void Handle(ErrorNotification errorNotification);
    }
}
