using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName ="Lessons/Lessons1/Rotate Settings")]
    public class RotateSet : ScriptableObject
    {
        [SerializeField]
        private int speed;

        public int Speed
        {
            get { return speed; }
           private set { speed = value; }
        }


    }


}

