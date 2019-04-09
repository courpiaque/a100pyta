using a100pyta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace a100pyta.ModelViews
{
    public class MainGameViewModel
    {
        Pytania pytania = new Pytania();

        public string GetQuest()
        {
            return pytania.GetRandomQuestion();
        }

        public string GetCount()
        {
            pytania.x++;
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
    }
}
