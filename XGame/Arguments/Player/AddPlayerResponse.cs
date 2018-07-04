namespace XGame.Domain.Arguments.Player
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using XGame.Domain.Interfaces.Arguments;

    public class AddPlayerResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

    }
}
