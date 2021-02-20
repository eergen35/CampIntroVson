using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {

                ID = 1,
                BirthYear = "1984",
                FirstName = "ERKAN",
                LastName = "ERGEN",
                IdentityNumber = 123456,
            });
        }
    }
}
