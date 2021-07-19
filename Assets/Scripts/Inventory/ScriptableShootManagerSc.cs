using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/scriptableShootManager ItemData")]

    public class ScriptableShootManagerSc : AbstractScriptableManagerSc<ScriptableShootManagerSc>
   {
       public void Shoot()
        {
            
            Debug.Log("Shoot Activated");

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
