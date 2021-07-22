using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/playerCannon ItemData")]
    public class PlayerInventoryCannonItemDataSc : AbstractPlayerInventoryItemData<PlayerInventoryCannonMONO>
    {
        public float damage;
        public override void CreateIntoInventory(PlayerInventorySc playerInventorySc)
        {
            var instantiated = InstantiatePrefabIntoParent(playerInventorySc.Parent);

            Debug.Log("THis class Cannon of Player");

        }

        public void Shoot()
        {
            instantiated.Shoot();

        }
    }

   


}
