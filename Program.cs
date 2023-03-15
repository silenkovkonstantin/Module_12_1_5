using System;

namespace Module_12_1_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user1 = new() { Login = "Ivan", Name = "Иван", IsPremium = true, };
            User user2 = new() { Login = "Maria", Name = "Мария", IsPremium = false, };

            List<User> users = new() { user1, user2 };

            GreeingUsers(users);
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void GreeingUsers(List<User> users)
        {
            foreach(User user in users)
            {
                string greetings = "Привет " + user.Name + "!";
                Console.WriteLine(greetings);

                if (!user.IsPremium)
                {
                    ShowAds();
                }
            }
        }
    }
}