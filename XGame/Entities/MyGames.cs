namespace XGame.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MyGames
    {
        public Guid Id { get; set; }
        public PlatformGame PlatformGame { get; set; }
        public bool Favorite { get; set; }
        public bool Trade { get; set; }
        public bool Sell { get; set; }
        public DateTime FavoriteDate { get; set; }

    }
}
