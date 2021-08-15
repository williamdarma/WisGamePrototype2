using Project.Components;
using System;
using UnityEngine;
using System.Collections;
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
            Debug.Log(_upgradeavleRepo); 
            _upgradeavleRepo.FetchingData(getUpgradeableData);
            
        }
       
        private void getUpgradeableData(UpgradeableData obj)
        {
            _upgradeableData = obj;

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