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
                var player = new Player
                {
                    Email = addPlayerRequest.Email,
                    Id = Guid.NewGuid(),
                    Name= addPlayerRequest.Name,
                    Password = addPlayerRequest.Password,
                    Status = Enums.EnumPlayerStatus.Active
                };

                var playerId = this.playerRepository.AddPlayer(player);

                return new AddPlayerResponse
                {
                    Id = playerId,
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
            //if (!this.ValidateAuthenticatePlayerRequest(authenticatePlayerRequest))
            //{

            //    throw new Exception("Missing arguments");
            //}
            var player = new Player(authenticatePlayerRequest.Email, authenticatePlayerRequest.Password);
            
            if (player.IsInvalid())
            {
                player?.DisplayNotifications();
                return null;
            }

            return this.playerRepository.AuthenticatePlayer(player);
        }
    }
}
