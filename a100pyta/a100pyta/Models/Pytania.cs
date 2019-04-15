using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace a100pyta.Models
{
    public class Pytania
    {
        private List<String> __questMaster;
        private LinkedList<String> __questShake;
        public static readonly string dataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Data");
        private int Randomness = 1;
        private Random randGen = new Random();
        private readonly string FileName = "pytania.txt";
        private string file;

        public int x = 100;

        public Pytania()
        {
            __questMaster = new List<String>(new String[]
            {"Jedna rzecz, z której jesteś dumny.",
            "Najbardziej charakterystyczne wspomnienie z dzieciństwa.",
            "Wielka rzecz lub błahostka, o której wiedzą tylko bliscy.",
            "Za co jesteś najbardziej wdzięczny?",
            "Kto jest Ci najbliższy w rodzinie?",
            "Najgłupsza rzecz jaką zrobiłeś.",
            "Najbardziej seksowna cecha partnera.",
            "Twoja największa zaleta charakteru.",
            "Do kogo się zwracasz gdy jest Ci źle?.",
            "To samo jedzenie do końca życia - co wybierasz?",
            "Twoja największa pasja.",
            "Musisz zrezygnować z jednego zmysłu, który wybierasz?",
            "Najgorsza praca jaką miałeś.",
            "Jedno słowo, które Cię definiuje.",
            "Najciekawsze miejsce w jakim byłeś.",
            "Jeden udany prezent jaki komuś dałeś/zrobiłeś.",
            "Ulubione wspomnienie z Twojego życia.",
            "Wymarzona pierwsza randka.",
            "Do jakiej rzeczy masz prawdziwy talent?",
            "Masz najlepszego przyjaciela? Jaki on jest?",
            "Decyzja, która zmieniła Twoje życie.",
            "Czego żałujesz, że nie zrobiłeś?",
            "Co zawsze poprawia Ci humor?",
            "Co chciałbyś zmienić w sobie?",
            "Twój ulubiony serwis społecznościowy.",
            "Kiedy ostatni raz płakałeś? Dlaczego?",
            "Bez jakiej rzeczy nie mógłbyś żyć?",
            "Najlepsze miejsce do wyjazdu na wakacje.",
            "Co decyduje o tym, że komuś ufasz?",
            "Jakiej rzeczy nauczyłeś się o sobie po swoim ostatnim związku?",
            "Wymarzona praca.",
            "Tytuł Twojej autobiografii.",
            "Twoje ulubione słowo.",
            "Jedna osoba, która pomogła Ci być takim jakim naprawdę jesteś.",
            "Jedna plotka na Twój temat.",
            "Jakiego pytania najbardziej nie lubisz?",
            "Twój sposób na rozpoczęcie konwersacji.",
            "Nawyk, z którym musisz walczyć.",
            "Kto jest Twoim bohaterem?",
            "Ulubiony gatunek filmowy.",
            "Rzecz, na którą nie żal Ci pieniędzy.",
            "Z kim chciałbyś utknąć w windzie?",
            "Ulubiona kreskówka.",
            "Najgorsza kontuzja.",
            "Jaką piosenkę zaśpiewałbyś na wieczorku karaoke?",
            "Ulubiony festiwal muzyczny",
            "Kto zna Cię najlepiej?",
            "Jak oceniasz miejsce, w którym mieszkasz?",
            "Nie jesteś jeszcze śpiący, co robisz wieczorem?",
            "Rzecz, na którą najbardziej narzekasz.",
            "Co chciałbyś zmienić w świecie?",
            "Co w sobie najbardziej lubisz?",
            "Czy uważasz się za osobę szczęśliwą? Dlaczego?",
            "Jaki był Twój ulubiony szkolny przedmiot?",
            "Jakie nadprzyrodzone moce chciałbyś mieć?",
            "W jakie zwierzę chciałbyś się zamienić na jeden dzień?",
            "Co chciałbyś powiedzieć całemu światu, gdyby wszyscy Cię słuchali?",
            "Jak bardzo się zmieniłeś w przeciągu ostatnich lat?",
            "Co Cię pociąga w płci przeciwnej?",
            "Do jakiej piosenki bądź filmu masz szczególny sentyment?",
            "Czy łatwo wybaczasz? Od czego to zależy.",
            "Jakiego zachowania szczególnie nie tolerujesz?",
            "Jaki jest Twój ulubiony środek transportu?",
            "Kim chciałeś być jak dorośniesz?",
            "Do czego masz największy szacunek?",
            "Ile na świecie jest osób, z których zdaniem się liczysz?",
            "Czy łatwo przychodzą Ci nowe znajomości? Dlaczego?",
            "Jak często myślisz o przeszłości?",
            "Jakie sprawiasz pierwsze wrażenie?",
            "Jak wyobrażasz sobie szczęście?",
            "Czy wierzysz w przeznaczenie?",
            "Jaka była najmilsza rzecz jaką usłyszałeś?",
            "Jak chcesz aby wyglądało Twoje życie za 5 lat?",
            "Jak wyglądał Twój dzień przed spotkaniem?",
            "Bez czego nie możesz wyjść z domu?",
            "Jakie trzy rzeczy zabrałbyś na bezludną wyspę?",
            "Jaka jest Twoja ulubiona pora roku?",
            "Jakiej nowej umiejętności chciałbyś się nauczyć?",
            "W jakich godzinach czujesz się najlepiej?",
            "Lepiej być jedynakiem, czy mieć dużo rodzeństwa?",
            "Czego nigdy nie zrobiłbyś nawet za dużą ilość pieniędzy?",
            "Czy przejmujesz się opinią innych?",
            "Jaka była Twoja ulubiona zabawa w dzieciństwie?",
            "Jak podobny do swoich rodziców jesteś?",
            "Jaki jest najgorszy domowy obowiązek?",
            "Wolisz spokojny wieczór w domu, czy zabawę w dużym gronie?",
            "Czego się boisz?",
            "Czy masz jakieś kompleksy?",
            "Czy łatwo się przywiązujesz?",
            "Jaki masz stosunek do alkoholu i używek?",
            "Czy jesteś marzycielem?",
            "Czy pieniądze pełnią w życiu dużą rolę? Jaki masz do nich stosunek?",
            "W jaką sławną osobę chciałbyś się zamienić na godzinę?",
            "Na co przeznaczyłbyś wygraną w totka?",
            "Jaki wyglądałby Twój wymarzony dom?",
            "Jakiego zachowania osób Twojej płci nie lubisz?",
            "Czego nie lubisz w otaczającej Cię rzeczywistości?",
            "Ile lat dają Ci obcy ludzie?",
            "Czy zrobiłeś kiedyś coś nielegalnego?",
            "Co byś zrobił gdybyś na jeden dzień zmienił płeć?"
            });

            __questShake = MakeRandomList();
            file = Path.Combine(dataDir, FileName);
        }

        private LinkedList<String> MakeRandomList()
        {
            if (__questShake == null) __questShake = new LinkedList<string>();
            List<String> copy = new List<string>(__questMaster);

            for (int k = 0; k < Randomness; ++k)
            {
                for (int i = 0; i < copy.Count; ++i)
                {
                    int randIdx = randGen.Next() % copy.Count;
                    //zamiana elementów
                    String pom = copy[i];
                    copy[i] = copy[randIdx];
                    copy[randIdx] = pom;
                }
            }
            foreach (var Var in copy)
                __questShake.AddFirst(Var);
            return __questShake;
        }

        public String GetRandomQuestion()
        {
            String question;
            if (__questShake == null || __questShake.Count < 1)
                __questShake = MakeRandomList();
            question = __questShake.First.Value;
            __questShake.RemoveFirst();
            return question;
        }

        public void SaveQuestionsToTxt()
        {
            Directory.CreateDirectory(dataDir);
            File.WriteAllLines(file, __questShake);
        }

        public void LoadQuestionsFromTxt()
        {
            List<string> allLinesText = File.ReadAllLines(file).ToList();
            __questShake = new LinkedList<string>(allLinesText);
            x = Math.Abs(__questShake.Count() - 100);
        }
    }
}
