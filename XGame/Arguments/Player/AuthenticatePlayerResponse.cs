using System;
using System.Collections.Generic;
using System.Text;
using XGame.Domain.Entities;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public static explicit operator AuthenticatePlayerResponse(Entities.Player v)
        {
            return new AuthenticatePlayerResponse
            {
                Email = v.Email.Address,
                FirstName = v.Name.FirstName,
                Message = "Ok"
            };
        }
    }
}
