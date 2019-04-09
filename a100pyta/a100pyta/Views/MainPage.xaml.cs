using a100pyta.Models;
using a100pyta.ModelViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a100pyta.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainPageViewModel();
            (BindingContext as MainPageViewModel).CheckDirectory();
        }

        private void NewGameBtn_Clicked(object sender, EventArgs e)
        {
            (BindingContext as MainPageViewModel).NewGame();
        }

        private void ContinueGameBtn_Clicked(object sender, EventArgs e)
        {
            (BindingContext as MainPageViewModel).ContinueGame();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            conti.IsVisible = (BindingContext as MainPageViewModel).Flag;
        }
    }
}