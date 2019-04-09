using Xamarin.Forms;
using a100pyta.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;
using a100pyta;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobBanner))]

namespace a100pyta.Droid
{
    public class AdMobBanner : ViewRenderer<AdMobView, AdView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var ad = new AdView(Android.App.Application.Context);
                ad.AdSize = AdSize.Banner;
                ad.AdUnitId = "ca-app-pub-4133089494678561/2507778223";

                var requestBuilder = new AdRequest.Builder();
                ad.LoadAd(requestBuilder.Build());
                SetNativeControl(ad);
            }
        }

        public AdMobBanner()
        {

        }
    }
}