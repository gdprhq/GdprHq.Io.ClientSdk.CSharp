using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GdprHq.Io.ClientSdk.Shared.Interfaces
{
    public interface INotificationTypeConverter
    {
        Enums.NotificationTypeEnum Convert(object type);
    }
}
