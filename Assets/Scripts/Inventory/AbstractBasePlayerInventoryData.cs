using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public abstract class AbstractBasePlayerInventoryData : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventorySc playerInventorySc);
        public virtual void Destroy()
        {
            Destroy(this);

        }
    }

}
