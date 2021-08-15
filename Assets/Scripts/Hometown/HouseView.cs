using System;
using UnityEngine;
using TMPro;
namespace Project.Hometown
{
    public class HouseView : MonoBehaviour
    {
        [SerializeField] private HouseController _houseController;
        public GameObject houseGameObject;
        Vector3 houseScale;
        Vector3 scaleChange;
        [SerializeField] int baseLevel;
        [SerializeField] int maxLevel;
        [SerializeField] Project.Components.Spawner spawner;
        [SerializeField] TextMeshPro levelText;

        private void Start()
        {
            Setup(_houseController);
            _houseController.setupData();
            baseLevel = _houseController.upgradeableData.Level;
            maxLevel = _houseController.upgradeableData.MaxLevel;
            houseScale = houseGameObject.transform.localScale;
            spawner = GetComponent<Project.Components.Spawner>();
            setText(baseLevel);
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
            if (baseLevel<maxLevel)
            {
                houseScale = houseGameObject.transform.localScale;
                scaleChange = new Vector3(.1f, .1f, .1f);
                houseScale += scaleChange;
                houseGameObject.transform.localScale = houseScale;
                baseLevel++;
                setText(baseLevel);
                if (baseLevel>= maxLevel)
                {                  
                    spawner.spawnTank();
                }
            }

        }

        void setText(int i)
        {
            if (i == maxLevel)
            {
                levelText.text = "Level: MAX";
            }
            else
            {
                levelText.text = "Level: " + i.ToString();
            }
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