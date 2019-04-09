using a100pyta.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace a100pyta.ModelViews
{
    public class MainGameViewModel
    {
        Pytania pytania = new Pytania();
        Random random = new Random();

        public string GetQuest()
        {
            return pytania.GetRandomQuestion();
        }

        public string GetCount()
        {
            pytania.x++;
            if (pytania.x == 100) RateUs();
            if (pytania.x == 101) pytania.x = 1;
            if (pytania.x % 5 == 0) GC.Collect();
            return pytania.x + "/100";            
        }

        public string ChangeBackground()
        {
            return "i" + pytania.x + ".png";           
        }

        public void SaveQuestions()
        {
            pytania.SaveQuestionsToTxt();
        }

        public void LoadQuestions()
        {
            pytania.LoadQuestionsFromTxt();
        }

        public string SetBackground()
        {
            return "i" + random.Next(1, 100) + ".png";
        }

        public async Task RateUs()
        {
            var action = await App.Current.MainPage.DisplayAlert("Oceń nas!", "Podziel się z nami swoją oceną naszej aplikacji.", "Wystaw ocenę", "Nie dziękuję");
            if (action)
            {
                Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=com.studio.billog.a100pyta"));
            }
        }
    }
}
