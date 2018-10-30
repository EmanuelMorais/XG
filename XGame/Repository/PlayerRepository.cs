namespace XGame.Domain.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using XGame.Domain.Arguments.Player;
    using XGame.Domain.Entities;
    using XGame.Domain.Interfaces.Repositorys;

    public class PlayerRepository : IPlayerRepository
    {
        public AddPlayerResponse AddPlayer(Player player)
        {
            return new AddPlayerResponse();
        }

        public AuthenticatePlayerResponse AuthenticatePlayer(Player player)
        {
            //return new AuthenticatePlayerResponse
            //{
            //    Email = authenticatePlayerRequest.Email.Address,
            //    FirstName = authenticatePlayerRequest.Name.FirstName
            //};

            return (AuthenticatePlayerResponse)player;
        }
    }
}
