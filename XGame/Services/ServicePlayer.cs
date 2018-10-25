namespace XGame.Domain.Services
{
    using System;
    using prmToolkit.NotificationPattern;
    using XGame.Domain;
    using XGame.Domain.Arguments.Player;
    using XGame.Domain.Entities;
    using XGame.Domain.Enums;
    using XGame.Domain.Interfaces.Repositorys;
    using XGame.Domain.Interfaces.Services;

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
                //var player = new Player
                //{
                //    Email = addPlayerRequest.Email,
                //    Id = Guid.NewGuid(),
                //    Name= addPlayerRequest.Name,
                //    Password = addPlayerRequest.Password,
                //    Status = Enums.EnumPlayerStatus.Active
                //};
                addPlayerRequest.Email.Address = string.Empty;
                var player2 = new Player(
                    Guid.NewGuid(),
                    addPlayerRequest.Email, 
                    addPlayerRequest.Password,
                    addPlayerRequest.Name,
                    EnumPlayerStatus.Active
                    );

                // var playerId = this.playerRepository.AddPlayer(player);
                if (player2.Notifications != null)
                {
                    foreach(var n in player2.Notifications)
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
