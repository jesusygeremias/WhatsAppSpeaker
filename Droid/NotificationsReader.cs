using System;
using Xamarin.Forms;
using Android;
using WhatsAppSpeaker.Droid;
using Android.Service.Notification;

[assembly: Dependency(typeof(NotificationsReader))]
namespace WhatsAppSpeaker.Droid
{
    public class NotificationsReader : INotificationsReader
    {
        public NotificationsReader()
        {
        }

        public string NotificationsText()
        {
            NotificationListenerService nls = new NotificationListenerService();
            /*if (nls != null)
            {
                foreach (StatusBarNotification notification in nls.GetActiveNotifications())
                {

                }
            }*/


        }
    }
}
