using System.Collections.Generic;
using Assets.Infrastructure;

namespace Assets
{
    public class ItemBuilder
    {
        private string _name = "Unset";
        

        public ItemBuilder(string name)
        {
            _name = name;
        }

        public ItemBuilder()
        {
         
        }



        public ItemBuilder Named(string name)
        {
            _name = name;
            return this;
        }
      
        public Item Build()
        {
            var item = new Item(_name);
            
            return item;
        }

        public static implicit operator Item(ItemBuilder itemBuilder)
        {
            return itemBuilder.Build();
        }
    }
}