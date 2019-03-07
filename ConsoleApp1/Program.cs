using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dz
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public Random rnd = new Random();

        public static void secondMax()
        {
            int x = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(1, 20);
                list.Add(x);
            }
            var tmp = list.Where(c => c != list.Max()).ToList();
            int secondMax = tmp.Max();

            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine("\nSecond max is {0} at {1}", secondMax, list.IndexOf(secondMax));

            var even = list.Where(e => e % 2 == 0).ToList();

            for (int i = 0; i < even.Count; i++)
                Console.Write(even[i] + " ");

        }

        public static void MoreThanAverage()
        {
            double x = 0;
            List<double> list = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(1, 30);
                list.Add(x);
            }

            double avg = list.Average();

            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > avg)
                {
                    Console.Write(list[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public static void printReverse()
        {

            string tmpr = "Тутанхамон — фараон Древнего Египта из XVIII династии Нового царства, правивший приблизительно в 1332—1323 годах до н. э. Его обнаруженная Говардом Картером в 1922 году практически не тронутая гробница KV62 в Долине Царей стала сенсацией и возродила интерес публики к Древнему Египту. Фараон и его золотая погребальная маска (ныне выставлена в Каирском египетском музее) с тех пор остаются популярными символами, а «мистические» смерти участников экспедиции 1922 года привели к возникновению понятия «проклятие фараонов».";

            StreamWriter SW = new StreamWriter(new FileStream("myText.txt", FileMode.Create, FileAccess.Write));
            SW.Write(tmpr);
            SW.Close();

            string readPath = @"myText.txt";
            List<string> txt = File.ReadAllLines(readPath).ToList();
            string tmp = "";

            for (int i = 0; i < txt.Count; i++)
                tmp += txt[i];


            string[] t2 = tmp.Split(' ');

            List<string> reversed = new List<string>();

            for (int i = 0; i < t2.Length; i++)
            {
                char[] arr = t2[i].ToCharArray();
                Array.Reverse(arr);

                tmp = new string(arr) + " ";
                reversed.Add(tmp);
            }

            for (int i = 0; i < reversed.Count; i++)
                Console.Write(reversed[i]);

        }

        public static bool EqualStrings()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            string tmp = "";

            if (s1.Length == s2.Length)
            {

                char[] arr = s2.ToCharArray();
                Array.Reverse(arr);

                tmp = new string(arr);

                if (s1 == tmp)
                {
                    Console.WriteLine("Straings are equal");
                    return true;
                }
                else
                {
                    Console.WriteLine("Strings are not equal");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("Unmatching sizes of strings");
                return false;

            }

        }

        public static void vowelsFirst()
        {
            string tmpr = "Тутанхамон — фараон Древнего Египта из XVIII династии Нового царства, правивший приблизительно в 1332—1323 годах до н. э. Его обнаруженная Говардом Картером в 1922 году практически не тронутая гробница KV62 в Долине Царей стала сенсацией и возродила интерес публики к Древнему Египту. Фараон и его золотая погребальная маска (ныне выставлена в Каирском египетском музее) с тех пор остаются популярными символами, а «мистические» смерти участников экспедиции 1922 года привели к возникновению понятия «проклятие фараонов».";

            StreamWriter SW = new StreamWriter(new FileStream("myText.txt", FileMode.Create, FileAccess.Write));
            SW.Write(tmpr);
            SW.Close();

            string readPath = @"myText.txt";

            List<string> txt = File.ReadAllLines(readPath).ToList();

            string vowels = "АЕЁИОУЭЮЯаеёиоуыэюя";
            string tmp = "";

            for (int i = 0; i < txt.Count; i++)
                tmp += txt[i];

            string[] tmp2 = tmp.Split(' ');
            for (int i = 0; i < tmp2.Length; i++)
            {
                char[] arr = tmp2[i].ToCharArray();
                if (vowels.Any(x => x == arr[0]))
                    Console.Write(tmp2[i] + " ");
            }

            Console.WriteLine("\nVowels:");

            for (int i = 0; i < tmp2.Length; i++)
            {
                char[] arr = tmp2[i].ToCharArray();
                if (!(vowels.Any(x => x == arr[0])))
                    Console.Write(tmp2[i] + " ");
            }

        }

        public static void Positive()
        {
            int[] arr = new int[20];
            string tmp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-20, 20);
                tmp += arr[i].ToString() + " ";
            }

            StreamWriter SW = new StreamWriter(new FileStream("myNumbers.txt", FileMode.Create, FileAccess.Write));
            SW.Write(tmp);
            SW.Close();

            string readPath = @"myNumbers.txt";

            List<string> numbers = File.ReadAllLines(readPath).ToList();
            for (int i = 0; i < numbers.Count; i++)
                tmp += numbers[i];

            Console.WriteLine("Positive numbers:");
            string[] tmp2 = tmp.Split(' ');

            for (int i = 0; i < tmp2.Length; i++)
                if ((!tmp2[i].StartsWith("-")))
                    Console.WriteLine(tmp2[i]);

            Console.WriteLine("\nОтрицательные числа");

            for (int i = 0; i < tmp2.Length; i++)
            {
                if (tmp2[i].StartsWith("-"))
                    Console.Write("{0} ", tmp2[i]);
            }
        }
    }
}