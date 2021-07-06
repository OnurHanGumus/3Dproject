using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControlRigidbodySc : MonoBehaviour
    {
        [SerializeField]
        ControlRigidbodySet controlRigidbody;
        Rigidbody rig;

        void Start()
        {
            rig = GetComponent<Rigidbody>();
        }

        void Update()
        {
            bool spaceDown = Input.GetButtonDown("Jump");
            if (spaceDown)
            {
                rig.AddForce(controlRigidbody.JumpForce, ForceMode.Impulse);
            }

        }
    }

}

