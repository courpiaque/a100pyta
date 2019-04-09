﻿using a100pyta.Models;
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
        private bool clicked = false;

        public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainPageViewModel();
            (BindingContext as MainPageViewModel).CheckDirectory();
        }

        private void NewGameBtn_Clicked(object sender, EventArgs e)
        {
            if (clicked == false)
                (BindingContext as MainPageViewModel).NewGame();
            clicked = true;
        }

        private void ContinueGameBtn_Clicked(object sender, EventArgs e)
        {
            if (clicked == false)
                (BindingContext as MainPageViewModel).ContinueGame();
            clicked = true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            conti.IsVisible = (BindingContext as MainPageViewModel).Flag;
            clicked = false;
        }
    }
}