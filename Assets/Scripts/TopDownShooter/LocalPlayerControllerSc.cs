using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Inventory;
using TopDownShooter.UserInput;

namespace TopDownShooter
{
    public class LocalPlayerControllerSc : MonoBehaviour
    {
        [SerializeField] PlayerInventorySc playerInventorySc;
        [SerializeField] InputManagerSet shootInput;

        void Update()
        {
            if (shootInput.Horizontal>0)
            {
                playerInventorySc.reactiveShootCommand.Execute();
            }

            
        }


    }


}

