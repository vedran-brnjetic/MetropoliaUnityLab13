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
            _player1 = (Player) A.Player().Named("Player 1");
            _player2 = (Player) A.Player().Named("Player 1");
            _hdd = (Item) An.Item().Named("HDD");
            _ram = (Item) An.Item().Named("RAM");
            _cpu = (Item) An.Item().Named("CPU");
            _room = (Room) A.Room().Named("Room");
            _room.AddPlayer(_player1).AddPlayer(_player2);
            _room.AddItem(_cpu).AddItem(_hdd).AddItem(_ram);


        }
	
        // Update is called once per frame
        void Update () {
		
        }
    }
}
