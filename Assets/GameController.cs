using Assets.Infrastructure;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

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



        //Buttons
        private Button _hddButton;
        private Button _cpuButton;
        private Button _ramButton;
        
        //UnityActions
        private UnityAction _hddButtonClick;
        private UnityAction _cpuButtonClick;
        private UnityAction _ramButtonClick;

        // Use this for initialization
        void Start ()
        {
            //A Room
            _room = (Room)A.Room().Named("Room");

            //Players
            _player1 = (Player) A.Player().Named("Player 1");
            _player2 = (Player) A.Player().Named("Player 2");

            //Items
            _hdd = (Item) An.Item().Named("HDD");
            _ram = (Item) An.Item().Named("RAM");
            _cpu = (Item) An.Item().Named("CPU");
            
            //Add players to the room
            _room.AddPlayer(_player1).AddPlayer(_player2);
            //Add items to the room 
            _room.AddItem(_cpu).AddItem(_hdd).AddItem(_ram);


            //Bind the buttons
            _cpuButton = GameObject.Find("btnCPU").GetComponent<Button>();
            _ramButton = GameObject.Find("btnRam").GetComponent<Button>();
            _hddButton = GameObject.Find("btnHDD").GetComponent<Button>();
            //Add listeners
            _cpuButton.onClick.AddListener(() => AddItemToInventory(_cpu));
            _hddButton.onClick.AddListener(() => AddItemToInventory(_hdd));
            _ramButton.onClick.AddListener(() => AddItemToInventory(_ram));



        }
	
        // Update is called once per frame
        void Update () {
		
        }

        public void AddItemToInventory(Item item)
        {
            if (_room.Items.Contains(item))
            {
                _room.CurrentPlayer.AddItemToInventory(item);
                _room.RemoveItem(item.Name);
                RefreshInventory();
                _room.ChangeActivePlayer();
                Text PlayerTurn = GameObject.Find("txtPlayerTurn").GetComponent<Text>();
                PlayerTurn.text = "Player:\n" + _room.CurrentPlayer.Name;
            }
        }

        public void RefreshInventory()
        {
            Text Player1Inventory = GameObject.Find("txtPlayer1Inventory").GetComponent<Text>();
            Text Player2Inventory = GameObject.Find("txtPlayer2Inventory").GetComponent<Text>();

            Player1Inventory.text = "";
            Player2Inventory.text = "";
            foreach (var item in _player1.Inventory)
            {
                Player1Inventory.text += item.Name + "\n";
            }
            foreach (var item in _player2.Inventory)
            {
                Player2Inventory.text += item.Name + "\n";
            }
        }
    }
}
