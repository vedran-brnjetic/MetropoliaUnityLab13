using System.Collections.Generic;

namespace Assets
{
    public class Room
    {
        private string _name;
        private List<Player> _players;
        private List<Item> _items;

        public Room()
        {
        }

        public Room(string name)
        {
            _players = new List<Player>();
            _name = name;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Player> Players
        {
            get { return _players; }
        }

        public Room AddPlayer(Player player)
        {
            _players.Add(player);
            return this;
        }

        public Room AddItem(Item item)
        {
            _items.Add(item);
            return this;
        }
    }
}