using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/scriptableShootManager ItemData")]

    public class ShootManagerSc : AbstractScriptableManagerSc<ShootManagerSc>
   {
       public void Shoot(Vector3 origin, Vector3 direction)
        {
            RaycastHit raycast;
            var physic = Physics.Raycast(origin, direction, out raycast);
            if (physic)
            {
                Debug.Log("collider: "+ raycast.collider.name);


            }

        }

        public override void Initialize()
        {
            Debug.Log("initialized.");

            base.Initialize();
        }

        public override void Destroy()
        {
            Debug.Log("destroyed.");

            base.Destroy();
        }
    }
   

}
