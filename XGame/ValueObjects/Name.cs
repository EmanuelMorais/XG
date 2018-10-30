using System;
using System.Collections.Generic;
using System.Text;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
    public  class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            new AddNotifications<Name>(this).IfNullOrInvalidLength(fn => fn.FirstName, 2, 50,Messages.Invalid.ToFormat("The first name"))
                                            .IfNullOrInvalidLength(fn => fn.LastName, 2, 50, Messages.Invalid.ToFormat("The last name"));
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
