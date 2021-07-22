using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public enum InventoryItemDataType {Cannon, Body }
    public abstract class AbstractPlayerInventoryItemData <T> : AbstractBasePlayerInventoryData where T: AbstractPlayerInventoryItemMono
    {
        [SerializeField] protected string _itemID;
        [SerializeField] protected InventoryItemDataType InventoryItemDataType;
        [SerializeField] protected T prefab;
        [SerializeField] protected T instantiated;

        protected T InstantiatePrefabIntoParent(Transform parent)
        {
            instantiated = Instantiate(prefab,parent);
            return instantiated;

        }
    }

}
