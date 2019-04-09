using a100pyta.ModelViews;
using Android.Gms.Ads;
using StoPyta_JedenOsiemL.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AdInterstitial))]

namespace StoPyta_JedenOsiemL.Droid
{
    public class AdInterstitial : IAdInterstitial
    {
        InterstitialAd interstitialAd;

        public AdInterstitial()
        {
            interstitialAd = new InterstitialAd(Android.App.Application.Context);
            interstitialAd.AdUnitId = "ca-app-pub-4133089494678561/4682052407";
            LoadAd();
        }

        public void LoadAd()
        {
            var requestbuilder = new AdRequest.Builder();
            interstitialAd.LoadAd(requestbuilder.Build());
        }

        public void ShowAd()
        {
            if (interstitialAd.IsLoaded) interstitialAd.Show();
            LoadAd();
        }
    }
}