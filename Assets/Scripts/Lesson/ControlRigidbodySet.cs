using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/ControlRigidbody Settings")]
    public class ControlRigidbodySet : ScriptableObject
    {
        [SerializeField]
        private Vector3 jumpForce;

        public Vector3 JumpForce
        {
            get { return jumpForce; }
           private set { jumpForce = value; }
        }

    }

}
