using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif

public class AndroidNotificationHandler : MonoBehaviour
{
#if UNITY_ANDROID

    private const string channelId= "notification_channel";
    public void ScheduleNotification(DateTime datetime)
    {
        AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel
        {
            Id = channelId,
            Name = "Notification Channel",
            Description = "Some random description",
            Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);
        AndroidNotification notification = new AndroidNotification
        {
            Title = "Energy Recharged!",
            Text = "Your energy has recharged, come back to play again!",
            SmallIcon ="default",
            LargeIcon = "default",
            FireTime = datetime
        };
        AndroidNotificationCenter.SendNotification(notification,channelId);
    }
#endif
}
