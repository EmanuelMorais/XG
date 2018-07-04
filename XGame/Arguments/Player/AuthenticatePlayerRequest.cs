using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest
    {
        public Email Email { get; set; }
        public string Password { get; set; }
    }
}