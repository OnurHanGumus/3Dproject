using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.UserInput
{
    public class InputManagerSc : MonoBehaviour
    {
    
        [SerializeField]
        InputManagerSet inputManagerSet;
        void Start()
        {

        }

        void Update()
        {
            inputManagerSet.Horizontal = Input.GetAxis("Horizontal");
            inputManagerSet.Vertical = Input.GetAxis("Vertical");
            inputManagerSet.Jump = Input.GetAxis("Jump");
        }
    }


}
