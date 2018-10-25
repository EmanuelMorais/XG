
namespace XGame.Domain.Interfaces.Services
{
    using System;
    using XGame.Domain.Arguments.Player;
    public interface IServicePlayer
    {

        AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerRequest authenticatePlayerRequest);
        AddPlayerResponse AddPlayer(AddPlayerRequest addPlayerRequest);
    }
}
