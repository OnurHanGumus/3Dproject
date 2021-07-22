using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/playerBody ItemData")]


    public class PlayerInventoryBodyItemDataSc : AbstractPlayerInventoryItemData<PlayerInventoryBodyMONO>
    {
        public override void CreateIntoInventory(PlayerInventorySc playerInventorySc)
        {
            var instantiated = InstantiatePrefabIntoParent(playerInventorySc.Parent);
            Debug.Log("THis class Body of Player");
            //ShootManagerSc.instance.Shoot();


        }

        
    }


}

