using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager =new  GamerManager
                (new UserValidationManager());

            gamerManager.Add(new Gamer { Id = 1, BirthDay = 1994, FirstName = "SERHAT", LastName = "YAŞ", TcNo = "12345" });
        }
    }
}
