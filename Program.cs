using System;
using System.Threading;

namespace algorithm
{
    internal class Program
    {
        private static User[] users;
        public static void Main(string[] args)
        {
            users = new User[]
            {
                new User()
                {
                    Login = "Serg123",
                    Name = "Сергей",
                    IsPremium = false
                },
                new User()
                {
                    Login = "kamin0",
                    Name = "Иван",
                    IsPremium = true
                },
                new User()
                {
                    Login = "lika",
                    Name = "Света",
                    IsPremium = false
                }
            };

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Привет, " + users[i].Name);
                if (!users[i].IsPremium) ShowAds();
            }
        }

        private static void ShowAds()
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
    }
}