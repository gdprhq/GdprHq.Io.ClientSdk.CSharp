using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GdprHq.Io.ClientSdk.Shared.Enums;

namespace GdprHq.Io.ClientSdk.Shared
{
    public class NotificationManager : Interfaces.INotificationManager
    {
        public void ReceiveNotification(object type, object notification)
        {
            NotificationTypeConverter notificationTypeConverter = new NotificationTypeConverter();
            Enums.NotificationTypeEnum notificationTypeEnum = notificationTypeConverter.Convert(type);

            switch (notificationTypeEnum)
            {
                case NotificationTypeEnum.Unknown:
                    break;
                case NotificationTypeEnum.Rectification:
                    Rights.Rectification rectification = new Rights.Rectification();
                    bool result = rectification.RectifyPersonalData(null, null);
                    SendNotification(notificationTypeEnum, null);
                    break;
                case NotificationTypeEnum.Erasure:
                    break;
                default:
                    break;
            }
        }

        public void SendNotification(Enums.NotificationTypeEnum type, object notification)
        {
            switch (type)
            {
                case NotificationTypeEnum.Unknown:
                    break;
                case NotificationTypeEnum.Rectification:
                    ApiCore apiCore = new ApiCore();
                    string json = apiCore.Call(Shared.Enums.ApiMethodEnum.POST, "api/Rights/Access/GetPurposeOfProcessing/", notification.ToString());
                    break;
                case NotificationTypeEnum.Erasure:
                    break;
                default:
                    break;
            }
        }
    }
}
