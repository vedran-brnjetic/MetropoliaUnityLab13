using System.Collections.Generic;
using UnityEngine;


namespace Assets
{
    public class Player
    {
        private string _name;
        private List<Item> _inventory;

        public Player(string name)
        {
            _inventory= new List<Item>();
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public List<Item> Inventory
        {
            get { return _inventory; }
        }


        public void AddItemToInventory(Item item)
        {
            _inventory.Add(item);
            
        }

        public void RemoveItem(string itemName)
        {
            Item item = null;
            
            foreach (var item1 in _inventory)
            {
                if (item1.Name == itemName)
                {
                    item = item1;

                }
            }
            if(item != null)
                _inventory.Remove(item);
            
            
        }
    }
}