using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControlRigidbodySc : MonoBehaviour
    {
        [SerializeField]
        Vector3 jumpForce;
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
                rig.AddForce(jumpForce, ForceMode.Impulse);
            }

        }
    }

}

