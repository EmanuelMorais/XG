namespace XGame.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public  class PlatformGame
    {
        public Guid Id { get; set; }
        public Game Game { get; set; }
        public Platform Platform { get; set; }
        public DateTime LaunchDate { get; set; }

    }
}
