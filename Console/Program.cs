using XGame.Domain.Arguments.Player;
using XGame.Domain.Services;
using XGame.Domain.ValueObjects;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Strart");
            var service = new ServicePlayer();


           // var addPlayerResponse = service.AddPlayer();

            var request = new AuthenticatePlayerRequest
            {
                Email = new Email { Address = "cenas@cenas.pt"},
                Password=""
            };

            var s = service.AuthenticatePlayer(request);
            System.Console.WriteLine("End");
            System.Console.ReadKey();
        }
    }
}
