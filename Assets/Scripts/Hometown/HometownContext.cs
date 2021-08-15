using Project.Components;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Hometown
{
    [RequireComponent(typeof(InputManager) , typeof(Spawner))]
    public class HometownContext : MonoBehaviour
    {
        [SerializeField]
        private InputManager _inputManager;
        [SerializeField]
        private Spawner _spawner;
        [SerializeField] HouseView houseView;
        public HouseController HouseController { get; private set; }
        

        private void Awake()
        {
            if(_inputManager == null)
            {
                _inputManager = GetComponent<InputManager>();
            }
            if (_spawner == null)
            {
                _spawner =  GetComponent<Spawner>();
            }
            if (houseView == null)
            {
                houseView = GetComponent<HouseView>();
            }
            //add implementation
        }

        private void OnEnable()
        {
            _inputManager.OnInputTouch += UpgradeHouse;
        }
        private void OnDisable()
        {
            _inputManager.OnInputTouch -= UpgradeHouse;
        }

        void UpgradeHouse()
        {
            houseView.scallingHouse();
        }

        private void OnDestroy()
        {
            //add implementation
        }
    }
}