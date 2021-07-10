using System.Collections;
using System.Collections.Generic;
using TopDownShooter.UserInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementSc : MonoBehaviour
    {
        [SerializeField]
        Rigidbody rig;
        [SerializeField]
        InputManagerSet inputManager;
        [SerializeField]
        PlayerMovementSet playerMovementSet;
        [SerializeField]
        Transform targetTransform = null;
        void Start()
        {
            rig = GetComponent<Rigidbody>();

        }
        void Update()
        {
            rig.MovePosition(rig.position + (rig.transform.forward * inputManager.Vertical * playerMovementSet.VerticalSpeed));
            //rig.MovePosition(rig.position+(rig.transform.right * inputManager.Horizontal* playerMovementSet.HorizontalSpeed));
            targetTransform.Rotate(0,inputManager.Horizontal * playerMovementSet.HorizontalSpeed,0,Space.Self);
            rig.AddForce(rig.transform.up * playerMovementSet.JumpSpeed.y*inputManager.Jump, ForceMode.Impulse);
        }

    }

}
