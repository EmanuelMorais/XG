using XGame.Domain.Arguments.Player;

namespace XGame.Domain
{
    public interface IPlayerValidations
    {
        bool ValidateAddPlayerRequest(AddPlayerRequest addPlayerRequest);

        bool ValidateAuthenticatePlayerRequest(AuthenticatePlayerRequest authenticatePlayerRequest);
    }
}