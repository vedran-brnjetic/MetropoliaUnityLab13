using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Infrastructure
{
    public class RoomBuilder
    {
        private string _name = "Unset";

        public RoomBuilder()
        {

        }

        public RoomBuilder Named(string name)
        {
            _name = name;
            return this;
        }

        public Room Build()
        {
            var room = new Room(_name);
            
            return room;
        }

        public static implicit operator Room(RoomBuilder roomBuilder)
        {
            return roomBuilder.Build();
        }

    }
}
