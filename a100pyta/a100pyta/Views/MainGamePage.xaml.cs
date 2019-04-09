using a100pyta.Models;
using a100pyta.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a100pyta.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainGamePage : ContentPage
	{
		public MainGamePage ()
		{
			InitializeComponent ();

            BindingContext = new MainGameViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var vm = (BindingContext as MainGameViewModel);
            label.Text = vm.GetQuest();
            counter.Text = vm.GetCount();
            BackgroundImage = vm.ChangeBackground();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            (BindingContext as MainGameViewModel).SaveQuestions();
        }

        public void Load()
        {
            if (label.Text == "Zaczynamy!")
            {
                label.Text = "Witaj ponownie!";
                BackgroundImage = (BindingContext as MainGameViewModel).SetBackground();
            }
                            
            (BindingContext as MainGameViewModel).LoadQuestions();
        }
    }
}