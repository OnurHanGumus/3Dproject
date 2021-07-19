using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.WheelRotate
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/Wheel Settings")]
    public class WheelRotateSet : ScriptableObject
    {
        public float wheelRollingSpeed = 1;
        public float wheelRotationSpeed = 1;

    }
}