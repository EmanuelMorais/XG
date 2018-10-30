using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositorys
{

    public interface IPlayerRepository
    {
        AuthenticatePlayerResponse AuthenticatePlayer(Player authenticatePlayerRequest);
        AddPlayerResponse AddPlayer(Player player);
    }
}
