using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.UserInput
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/InputManager Settings")]

    public class InputManagerSet : ScriptableObject
    {
        [SerializeField]
        private float horizontal;

        public float Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }

        [SerializeField]
        private float vertical;

        public float Vertical
        {
            get { return vertical; }
            set { vertical = value; }
        }

    }

}
