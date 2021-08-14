using System;
using UnityEngine;

namespace Project.Hometown
{
    public class HouseView : MonoBehaviour
    {
       [SerializeField] private HouseController _houseController;
        public GameObject houseGameObject;
        public HouseController test;
        Vector3 houseScale;
        Vector3 scaleChange;
        private void Start()
        {
            Setup(_houseController);
            _houseController.setupData();
            houseScale = houseGameObject.transform.localScale;
            scaleChange = new Vector3(.1f, .1f, .1f);
        }
        private void OnDisable()
        {
            //add implementation
        }

        private void OnEnable()
        {
            //add implementation

        }

        public void scallingHouse()
        {
            print(_houseController.upgradeableData.Level);
            houseScale = houseGameObject.transform.localScale;
            houseScale += scaleChange;
            houseGameObject.transform.localScale = houseScale;
        }

        public HouseView Setup(HouseController houseController)
        {
            _houseController= houseController;
            return this;
        }

        public void EnableScript()
        {
            //remember to enable script from context if needed
            enabled = true;
        }

        public void HandleOnHouseLevelUp(LevelupEventData data)
        {
            //add implementation
        }
    }
}