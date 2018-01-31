using System.Collections.Generic;
using UnityEngine;

namespace Assets.Infrastructure
{
    public class PlayerBuilder
    {

        private string _name="Unset";
        private List<Item> _items;

        public PlayerBuilder(string name)
        {
            _items=new List<Item>();
            _name = name;
        }

        public PlayerBuilder()
        {
            _items = new List<Item>();
        }

        public PlayerBuilder WithRoom()
        {
            return this;

        }

        public PlayerBuilder Named(string name)
        {
            _name = name;
            return this;
        }
        public PlayerBuilder WithItems(List<Item> items)
        {
            _items = items;
            return this;
        }

        public Player Build()
        {
            var player = new Player(_name);
            foreach (var item in _items)
            {
                player.Inventory.Add(item);
            }
            return player;
        }

        public static implicit operator Player(PlayerBuilder playerBuilder)
        {
            return playerBuilder.Build();
        }
    }
}
