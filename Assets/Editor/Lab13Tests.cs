using System.Collections.Generic;
using System.Diagnostics;
using Assets.Infrastructure;
using NUnit.Framework;
using Debug = UnityEngine.Debug;

namespace Assets
{
    public class Lab13Tests {

        [Test]
        public void PlayerClassExists()
        {
            var player = (Player) A.Player().Named("John");

            Assert.NotNull(player);
            Assert.AreEqual("John", player.Name);
        }

        [Test]
        public void Item_Gets_Added_To_Inventory()
        {
            var player = (Player) A.Player().Named("John");
            var item = (Item) An.Item().Named("TestItem");
            player.AddItemToInventory(item);

            Assert.AreEqual(1, player.Inventory.Count);
        }

        [Test]
        public void Item_Gets_Removed_From_Inventory()
        {
            var player = (Player) A.Player().Named("John").WithItems(
                new List<Item>()
                {
                    An.Item().Named("Item")
                });

            player.RemoveItem("Item");
            
            Assert.AreEqual(0, player.Inventory.Count);
        }

        [Test]
        public void RoomClassExists()
        {
            var room = (Room) A.Room().Named("Room1");

            Assert.NotNull(room);
        }

        [Test]
        public void Player_Gets_Added_To_Room()
        {
            var player = (Player) A.Player().Named("John");
            var room = (Room) A.Room().Named("Lobby");

            room.AddPlayer(player);

            Assert.AreEqual(1, room.Players.Count);
        }

        [Test]
        public void ItemClassExists()
        {
            var item = (Item) An.Item().Named("Item");

            Assert.NotNull(item);
        }

        [Test]
        public void Item_Gets_Added_To_Room()
        {
            var item = (Item) An.Item().Named("Item 1");
            var room = (Room) A.Room().Named("Room 1");

            room.AddItem(item);

            Assert.AreEqual(1, room.Items.Count);
        }

    }
}