using a100pyta.Views;
using a100pyta.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace a100pyta.ModelViews
{
    public class MainPageViewModel
    {
        public bool Flag { get; set; } = false;

        MainGamePage page;
        DirectoryInfo d = new DirectoryInfo(Pytania.dataDir);

        public void NewGame()
        {
            page = new MainGamePage();
            Flag = true;
            App.Current.MainPage.Navigation.PushModalAsync(page);
        }

        public void ContinueGame()
        {
            if (page == null)
                page = new MainGamePage();
            page.Load();
            App.Current.MainPage.Navigation.PushModalAsync(page);
        }

        public void CheckDirectory()
        {
            if (d.Exists)
            {
                Flag = true;
                System.Diagnostics.Debug.WriteLine("Jest katalog");
            }
            else if (!d.Exists)
            {
                Flag = false;
                System.Diagnostics.Debug.WriteLine("Nie ma katalogu");
            }
        }
    }
}
