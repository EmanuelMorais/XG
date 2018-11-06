namespace XGame.Domain.Services
{
    using prmToolkit.NotificationPattern;
    using System;
    using System.Reflection;
    using XGame.Domain.Arguments.Player;
    using XGame.Domain.Entities;
    using XGame.Domain.Interfaces.Repositorys;
    using XGame.Domain.Interfaces.Services;
    using XGame.Domain;
    using System.Linq;
    using XGame.Domain.Enums;

    public class ServicePlayer : Notifiable, IServicePlayer
    {
        private readonly IPlayerRepository playerRepository;
        public ServicePlayer(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public ServicePlayer()
        {

        }
        public AddPlayerResponse AddPlayer(AddPlayerRequest addPlayerRequest)
        {
            if (addPlayerRequest.ValidateAddPlayerRequest())
            {
                var player = this.playerRepository.GetPlayer(addPlayerRequest.Email, addPlayerRequest.Name);
                if (player != null)
                {
                    return new AddPlayerResponse
                    {
                        Message="Player allready exists"
                    };
                }
                var player2 = new Player(
                    Guid.NewGuid(),
                    addPlayerRequest.Email, 
                    addPlayerRequest.Password,
                    addPlayerRequest.Name,
                    EnumPlayerStatus.Active
                    );

                // var playerId = this.playerRepository.AddPlayer(player);
                if (player.Notifications != null)
                {
                    foreach(var n in player.Notifications)
                    {
                        Console.WriteLine("{0} : {1}",n.Property,n.Message);
                    }
                }
                return new AddPlayerResponse
                {
                    Id = Guid.NewGuid(),
                    Message = "Adicionado com sucesso"
                };
            }
            else
            {
                
                throw new ArgumentNullException("addPlayerRequest");
            }
        }

        public AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerRequest authenticatePlayerRequest)
        {
            if (authenticatePlayerRequest == null)
            {
                AddNotification("AuthenticatePlayer", "authenticatePlayerRequest can't be null");
            }
            
            

            return null;
        }
    }
}
