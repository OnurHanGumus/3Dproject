using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace TopDownShooter.Inventory
{
    public abstract class AbstractBasePlayerInventoryData : ScriptableObject
    {
        PlayerInventorySc playerInventorySc;
        protected CompositeDisposable disposables;
        public virtual void Initialize(PlayerInventorySc targetPlayerInventorySc)
        {
            playerInventorySc = targetPlayerInventorySc;
            disposables = new CompositeDisposable();
        }
       
        public virtual void Destroy()
        {
            Destroy(this);

        }
    }

}
