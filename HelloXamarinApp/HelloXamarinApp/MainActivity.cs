using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace HelloXamarinApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        int count = 1; //count = muuttuja

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //aktiviteetti, jolla on OnCreate tapahtuma
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //id = MyButton
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //tapahtuman käsittelijä - delegaatti l. rutiini, joka hoita tapahtuman käsittelyn
            button.Click += delegate {
                //koodirivi: päivitetään napin tekstiä
                button.Text = string.Format("{0} clicks!", count++);
            };
        }
    }
}

