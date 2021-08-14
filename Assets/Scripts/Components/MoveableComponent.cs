using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Components
{
    public class MoveableComponent : MonoBehaviour
    {
        [SerializeField] private Vector3 _destination;
        [SerializeField] float speed=1f;
        public void SetDestination(Vector3 destination)
        {
            //add implementation to move this object to destination
            //and destroy it when it reach the destination
            //desination must be some vector3 where y and z coordinate not change from current coordinate
            //only x coordinate change and to positive direction (to the right)
            transform.position = Vector2.MoveTowards(transform.position, _destination, 1*Time.deltaTime);
            if (transform.position.x == _destination.x)
            {
                gameObject.SetActive(false);
            }
        }

        private void OnEnable()
        {
            
        }

        private void Update()
        {
            SetDestination(_destination);
        }

    }
}