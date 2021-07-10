using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.UserInput
{
    public class InputManagerSc : MonoBehaviour
    {
    
        [SerializeField]
        InputManagerSet inputManagerSet;

        [SerializeField] InputManagerSet[] inputManagerArray;
        void Start()
        {

        }

        void Update()
        {
            inputManagerSet.Horizontal = Input.GetAxis("Horizontal");
            inputManagerSet.Vertical = Input.GetAxis("Vertical");
            inputManagerSet.Jump = Input.GetAxis("Jump");

            for (int i = 0; i < inputManagerArray.Length; i++)
            {
                inputManagerArray[i].ProcessInput();
            }
        }
    }


}
