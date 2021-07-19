using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class AbstractScriptableManagerSc<T> : AbstractScriptableBaseSc where T:AbstractScriptableManagerSc<T>
    {
        public static T instance;
        public override void Initialize()
        {
            instance = this as T;
            base.Initialize();
        }

        public override void Destroy()
        {
            base.Destroy();
        }


    }
}
