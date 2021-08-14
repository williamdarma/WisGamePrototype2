using Project.Components;
using System;
using UnityEngine;

namespace Project.Hometown
{
    [Serializable]
    public class HouseController : IController, IUpgradeable, ICanTriggerSpawn
    {
        public event Action<LevelupEventData> OnLevelUp;
        public event Action TriggerSpawn;

        private HometownContext _hometownContext;
        private string _itemName;
        private UpgradeableData _upgradeableData;
        public UpgradeableData upgradeableData { get { return _upgradeableData; } }
        public event Action<UpgradeableData> data;
        public UpgradeableRepository _upgradeavleRepo;

        public void OnContextDispose()
        {
            //add implementation
        }

        public HouseController(HometownContext hometownContext, string upgradeableItemName, InputManager inputManager)
        {
            _hometownContext = hometownContext;
            _itemName = upgradeableItemName;

            //add implementation
        }

       public void setupData()
        {
            UpgradeableData test = new UpgradeableData(0,0);
            _upgradeableData = test;


        }

        public void Upgrade()
        {
            Debug.Log($"Handle Upgrade {_itemName}");
            //add implementation
        }

        public void HandleOnInputTouch()
        {
            //add implementation
        }

    }
}