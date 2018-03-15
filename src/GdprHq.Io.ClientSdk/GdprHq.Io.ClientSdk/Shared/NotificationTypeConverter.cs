using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GdprHq.Io.ClientSdk.Shared.Enums;

namespace GdprHq.Io.ClientSdk.Shared
{
    public class NotificationTypeConverter : Interfaces.INotificationTypeConverter
    {
        public NotificationTypeEnum Convert(object type)
        {
            switch (type.ToString())
            {
                case "rectification":
                    return NotificationTypeEnum.Rectification;
                case "erasure":
                    return NotificationTypeEnum.Erasure;
                default:
                    return NotificationTypeEnum.Unknown;
            }
        }
    }
}
