using System;
using System.Collections.Generic;
using System.Text;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}
