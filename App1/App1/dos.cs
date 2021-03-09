using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using static Android.Resource;

namespace App1
{
    [Activity(Label = "dos")]
    public class dos : Activity
    {
        

        private Button b;
        private string CHANNEL_ID = "1";
        string x = string.Empty;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.dos);
            // Create your application here
           
             x = Intent.GetStringExtra("extra");
            TextView txt = FindViewById<TextView>(Resource.Id.textView1);
            //    Intent.GetStringExtra("parametro")
            Toast.MakeText(ApplicationContext, "" + x, ToastLength.Long).Show();
            b = FindViewById<Button>(Resource.Id.bt1);

            NotificationCompat.Builder builder = new NotificationCompat.Builder(this, CHANNEL_ID)
                .SetContentTitle("dani")
                .SetContentText("hola")
                .SetSound(RingtoneManager.GetDefaultUri(RingtoneType.Notification))
                .SetSmallIcon(Resource.Drawable.LogoNotif);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager =
                GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);

            b.Click += B_Click;
        }

        private void B_Click(object sender, EventArgs e)
        {
            
NotificationCompat.Builder builder = new NotificationCompat.Builder(this, CHANNEL_ID)
    .SetContentTitle(x)
    .SetContentText( x)

                        .SetSound(RingtoneManager.GetDefaultUri(RingtoneType.Notification))
    .SetSmallIcon(Resource.Drawable.LogoNotif);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager =
                GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);


        }
    }
}