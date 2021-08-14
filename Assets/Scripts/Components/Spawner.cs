using UnityEngine;
using System.Collections.Generic;
namespace Project.Components
{

    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private MoveableComponent _moveableComponent;

        [SerializeField] List<GameObject> listTankPool = new List<GameObject>();
        [SerializeField] int totalPool = 5;
        [SerializeField] Transform spawnPoint;

        void setupPool()
        {
            for(int i = 0; i < totalPool;i++)
            {
                GameObject tank = Instantiate(_moveableComponent.gameObject, gameObject.transform);
                listTankPool.Add(tank);
                tank.SetActive(false);
            }
        }
        private void Awake()
        {
            setupPool();
        }

        void spawnTank()
        {
            InvokeRepeating("testingSpawn", 1f, 2f);
        }

        void poolingSpawn()
        {
            foreach(GameObject go in listTankPool)
            {
                if (!go.activeInHierarchy)
                {
                    go.SetActive(true);
                    go.transform.position = spawnPoint.transform.position;
                    go.transform.rotation = spawnPoint.transform.rotation;
                    break;
                }
            }
        }

        private void OnDisable()
        {
            //add implementation
        }

        private void OnEnable()
        {
            //add implementation
        }

        public void Setup(ICanTriggerSpawn spawnTrigger)
        {
            //add implementation
        }

        public void EnableScript()
        {
            //remember to enable script from context if needed
            enabled = true;
        }

        public void HandleOnSpawnTriggered()
        {
            //add implementation
        }

        private void SpawnMoveableObject()
        {
            //add implementation
        }
    }
}