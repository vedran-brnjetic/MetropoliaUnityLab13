using System.Collections.Generic;

namespace Assets
{
    public class Room
    {
        private string _name;
        private List<Player> _players;
        private List<Item> _items;

        private Player _currentPlayer;

        public Room()
        {
            _players = new List<Player>();
            _items = new List<Item>();

        }

        public Room(string name)
        {
            _players = new List<Player>();
            _items = new List<Item>();
            _name = name;
            if (_players.Count > 0)
            {
                _currentPlayer = _players[0];
            }
        }

        public void ChangeActivePlayer()
        {
            if (_players.IndexOf(_currentPlayer) == _players.Count - 1)
            {
                _currentPlayer = _players[0];
            }
            else
            {
                _currentPlayer = _players[_players.IndexOf(_currentPlayer) + 1];
            }
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
        public List<Item> Items
        {
            get { return _items; }
        }

        public Room AddPlayer(Player player)
        {
            _players.Add(player);
            if (_players.Count == 1)
            {
                _currentPlayer = _players[0];
            }
            return this;
        }

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
        }

        public Room AddItem(Item item)
        {
            _items.Add(item);
            return this;
        }

        public void RemoveItem(string itemName)
        {
            Item item = null;

            foreach (var item1 in _items)
            {
                if (item1.Name == itemName)
                {
                    item = item1;

                }
            }
            if (item != null)
                _items.Remove(item);


        }
    }
}