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
        public Guid AddPlayer(AddPlayerRequest addPlayerRequest)
        {

            if (addPlayerRequest.ValidateAddPlayerRequest())
            {
                throw new ArgumentException("Invalid request");
            }
            try
            {
                var player = new Player(
                                    Guid.NewGuid(),
                                    addPlayerRequest.Email,
                                    addPlayerRequest.Password,
                                    addPlayerRequest.Name,
                                    EnumPlayerStatus.OnGoing);

                var response = playerRepository.AddPlayer(player);

                return response.Id;

            }
            catch (Exception ex)
            {

                throw new ArgumentException("Fail to add player",ex.InnerException.Message,ex);
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
