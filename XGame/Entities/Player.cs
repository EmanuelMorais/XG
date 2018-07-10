namespace XGame.Domain.Entities
{
    using prmToolkit.NotificationPattern;
    using prmToolkit.NotificationPattern.Extensions;
    using System;
    using XGame.Domain.Enums;
    using XGame.Domain.Resources;
    using XGame.Domain.ValueObjects;

    public class Player : Notifiable
    {
        public Player(
            Guid id,
            Email email, 
            string password,
            Name name,
            EnumPlayerStatus status
            )
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            Status = status;
            this.AddPlayerNotification();
        }

        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public EnumPlayerStatus Status { get; private set; }

    }
}
