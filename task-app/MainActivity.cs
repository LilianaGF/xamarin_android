using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;

namespace task_app
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //                                                  //tag for Log.info() method.
        readonly string tag = "LGF";
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Log.Debug(tag, "The onCreate() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(tag, "The OnStart() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnResume()
        {
            base.OnResume();
            Log.Debug(tag, "The OnResume() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnPause()
        {
            base.OnPause();
            Log.Debug(tag, "The OnPause() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(tag, "The OnStop() event");
        }
        //--------------------------------------------------------------------------------------------------------------
        protected override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug(tag, "The OnDestroy() event");
        }
        //--------------------------------------------------------------------------------------------------------------
    }
    /*END-ACTIVITY*/
}

