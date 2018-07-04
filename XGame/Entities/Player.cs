namespace XGame.Domain.Entities
{
    using prmToolkit.NotificationPattern;
    using System;
    using XGame.Domain.Enums;
    using XGame.Domain.ValueObjects;

    public class Player : Notifiable
    {
        public Player()
        {

        }
        public Player(Email email, string password)
        {
            Email = email;
            Password = password;
            new AddNotifications<Player>(this)
                .IfNullOrEmpty(x => x.Email.Address, "Email invalido")
                .IfNullOrInvalidLength(p => p.Password, 6, 12, "");
            
        }

        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
        public EnumPlayerStatus Status { get; set; }

    }
}
