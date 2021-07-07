using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{

    [CreateAssetMenu(menuName = "Lessons/Lessons1/CameraController Settings")]

    public class CameraControllerSet : ScriptableObject
    {
        [Header("rotation")]

        [SerializeField]
        private int rotationSpeed;

        public int RotationSpeed

        {
            get { return rotationSpeed; }
           private set { rotationSpeed = value; }
        }
        [Header("position")]

        [SerializeField]
        private Vector3 offset;

        public Vector3 Offset

        {
            get { return offset; }
            private set { offset = value; }
        }


        [SerializeField]
        private float positionLerp;

        public float PositionLerp

        {
            get { return positionLerp; }
            private set { positionLerp = value; }
        }

    }

}

