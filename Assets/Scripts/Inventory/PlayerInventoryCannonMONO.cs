using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class PlayerInventoryCannonMONO : AbstractPlayerInventoryItemMono
    {
        [SerializeField] Transform cannonShootPoint;
       public void Shoot()
        {
            ShootManagerSc.instance.Shoot(cannonShootPoint.position,cannonShootPoint.forward);
            Debug.Log("shooted");
        }
    }


}
