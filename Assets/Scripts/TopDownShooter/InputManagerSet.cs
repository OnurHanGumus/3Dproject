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

        [SerializeField]
        private float jump;

        public float Jump
        {
            get { return jump; }
            set { jump = value; }
        }

        private float horizontalTower;

        public float HorizontalTower
        {
            get { return horizontalTower; }
            set { horizontalTower = value; }
        }



        [Header("Axis base control")]
        [SerializeField] private bool _axisActive;
        string AxisNameHorizontal = "Horizontal";
        string AxisNameVertical="Vertical";
        

        [Header("Key base control")]
        [SerializeField] private bool _keybaseHorizontalActive =false;
        private bool _keybaseVerticalActive = false;
        [SerializeField] private KeyCode positiveHorizontalKeyCode;
        private KeyCode positiveVerticalKeyCode;
        [SerializeField] private KeyCode negativeHorizontalKeyCode;
        private KeyCode negativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount = 0.015f;


        public void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(AxisNameHorizontal);
                Vertical = Input.GetAxis(AxisNameVertical);
            }
            else
            {
                if (_keybaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref horizontalTower, positiveHorizontalKeyCode,negativeHorizontalKeyCode);
                }
                if (_keybaseVerticalActive)
                {
                    KeyBaseAxisControl(ref vertical, positiveVerticalKeyCode, negativeVerticalKeyCode);

                }
            }

        }

        private void KeyBaseAxisControl(ref float value,KeyCode positive, KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);    
            bool negativeActive = Input.GetKey(negative);
            if (positiveActive)
            {
                value += _increaseAmount;
            }
            else if (negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;

            }

            value = Mathf.Clamp(value,-1,1);
        }


    }

}
