namespace XGame.Domain.Arguments.Player
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using XGame.Domain.Interfaces.Arguments;
    using XGame.Domain.ValueObjects;

    public class AddPlayerRequest : IRequest
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }

    }
}
