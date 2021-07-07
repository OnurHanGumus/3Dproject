using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/playermovement Settings")]

    public class PlayerMovementSet : ScriptableObject
    {
        [SerializeField]
        private float horizontalSpeed=5;

        public float HorizontalSpeed
        {
            get { return horizontalSpeed; }
            set { horizontalSpeed = value; }
        }

        [SerializeField]
        private float verticalSpeed=5;

        public float VerticalSpeed
        {
            get { return verticalSpeed; }
            set { verticalSpeed = value; }
        }

        [SerializeField]
        private Vector3 jumpSpeed;

        public Vector3 JumpSpeed
        {
            get { return jumpSpeed; }
            set { jumpSpeed = value; }
        }

    }


}

