
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;



namespace TestTapTap;
class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя: ");

        Console.ReadLine();

        Console.WriteLine("Нажмите Enter чтобы начать");
        
        StartText();
        

    }
    static void StartText()
    {
        var timer = new Stopwatch();

        timer.Start();
        while (timer.Elapsed < TimeSpan.FromSeconds(30))
        {
            string text = "Не всё в Мондштадте сотворено Анемо Архонтом.Сейчас я вознесу похвалу о том, как прекрасно всё сущее...Хвала западному ветру за вечную ласку,цветам за прекрасную весеннюю сказку,зяблики, утки, кроли, кабаны, равнины Мондштадта, что жизни полны.Бродит лев средь зелёных лугов,такой он красавец, что других нету слов.Жаркая грива солнца видна,потому так приятна прохлада вина.Тонкая тропка меж гор ковыляет,по ней ветер восточный не ходит - летает.Полями, садами он низко пройдёт,запахи фруктов он нам принесёт.Северный ветер дремлет в лесу,а серые волки ходят внизу.Анемо Архонту известно, что он увидит чудный, ласковый сон.Времена года друг за другом идут, и эти ветра никогда не умрут.Главная роль в этой песне - моя,ведь кто её спел бы, если не я?";

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                
                Console.WriteLine(text);
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            
        }
        
        timer.Stop();
        Console.SetCursorPosition(0, 10);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Время истекло");
        


    }
    static void Timer()
    {
        var dateTime = DateTime.Now;
        DateTime dt = dateTime.AddMinutes(-1);
        while (dateTime > dt)
        {

            var ticks = (dateTime - dt).Ticks;
            
            Console.WriteLine(new DateTime(ticks).ToString("mm:HH:ss"));
            Thread.Sleep(1000);
            dt = dt.AddSeconds(1);
            
        }
        Console.ReadKey();
    }
    //static void Table()
    //{
    //    Person record = new Person();
    //    record.Name = "";
    //    record.Time = 

    //}


}
    

