using Assets.Infrastructure;
using UnityEngine;

namespace Assets
{
    public class GameController : MonoBehaviour
    {
        private Player _player1;
        private Player _player2;
        private Item _hdd;
        private Item _ram;
        private Item _cpu;

        private Room _room;
        // Use this for initialization
        void Start ()
        {
            //A Room
            _room = (Room)A.Room().Named("Room");

            //Players
            _player1 = (Player) A.Player().Named("Player 1");
            _player2 = (Player) A.Player().Named("Player 1");

            //Items
            _hdd = (Item) An.Item().Named("HDD");
            _ram = (Item) An.Item().Named("RAM");
            _cpu = (Item) An.Item().Named("CPU");
            
            //Add players to the room
            _room.AddPlayer(_player1).AddPlayer(_player2);
            //Add items to the room 
            _room.AddItem(_cpu).AddItem(_hdd).AddItem(_ram);


        }
	
        // Update is called once per frame
        void Update () {
		
        }
    }
}
