using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Shared.Interfaces
{
    public interface INotificationManager
    {
        void ReceiveNotification(object type, object notification);
        void SendNotification(Enums.NotificationTypeEnum type, object notification);
    }
}
