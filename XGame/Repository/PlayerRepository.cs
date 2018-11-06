namespace XGame.Domain.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using XGame.Domain.Arguments.Player;
    using XGame.Domain.Entities;
    using XGame.Domain.Interfaces.Repositorys;
    using XGame.Domain.ValueObjects;

    public class PlayerRepository : IPlayerRepository
    {
        public Guid AddPlayer(Player player)
        {
            return Guid.NewGuid();
        }

        public AuthenticatePlayerResponse AuthenticatePlayer(Player authenticatePlayerRequest)
        {
            return new AuthenticatePlayerResponse
            {
                Email = authenticatePlayerRequest.Email.Address,
                FirstName = ""
            };
        }

        public Player GetPlayer(Email email, Name name)
        {
            throw new NotImplementedException();
        }
    }
}
