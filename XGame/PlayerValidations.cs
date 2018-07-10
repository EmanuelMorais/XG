using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;
using XGame.Domain.Resources;

namespace XGame.Domain
{
    public static class PlayerValidations
    {
        public static void DisplayNotifications(this Player player)
        {
            var notifications = player.Notifications;
            foreach (var n in notifications)
            {
                Console.WriteLine("{0}Error: {1}", n.Property, n.Message);
            }
        }

        public static void ValidatePassowrd(this string password)
        {
            if (password.Length < 6)
                throw new ArgumentException("Minimum length is 6");
        }

        public static bool ValidateAddPlayerRequest(this AddPlayerRequest addPlayerRequest)
        {
            return !string.IsNullOrEmpty(addPlayerRequest?.Email?.Address)
                  && !string.IsNullOrEmpty(addPlayerRequest?.Name?.FirstName)
                  && !string.IsNullOrEmpty(addPlayerRequest?.Name?.LastName)
                  && !string.IsNullOrEmpty(addPlayerRequest?.Password);
        }


        public static bool ValidateAuthenticatePlayerRequest(this AuthenticatePlayerRequest authenticatePlayerRequest)
        {
            return !string.IsNullOrEmpty(authenticatePlayerRequest?.Email.Address) && !string.IsNullOrEmpty(authenticatePlayerRequest?.Password);
        }


        //public static bool IsAnyNullOrEmpty(object myObject)
        //{
        //    foreach (PropertyInfo pi in myObject.GetType().GetProperties())
        //    {
        //        if (pi.PropertyType == typeof(string))
        //        {
        //            string value = (string)pi.GetValue(myObject);
        //            if (string.IsNullOrEmpty(value))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        public static void AddPlayerNotification(this Player player)
        {
            new AddNotifications<Player>(player)
            .IfNullOrEmpty(x => x.Email.Address, Messages.Invalid.ToFormat(nameof(player.Email.Address)))
            .IfNullOrInvalidLength(p => p.Password, 6, 12, "")
            .IfNullOrEmpty(n => n.Name.FirstName, "Invalid First Name")
            .IfNullOrEmpty(n => n.Name.LastName, "Invalid Last Name")
            .IfEnumInvalid(e => e.Status, "Invalid Status");
        }
    }
}
