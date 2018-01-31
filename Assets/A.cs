using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Infrastructure
{
    public static class A
    {
        public static PlayerBuilder Player()
        {
            return new PlayerBuilder();
        }

        public static RoomBuilder Room()
        {
            return new RoomBuilder();
        }
    }
}
