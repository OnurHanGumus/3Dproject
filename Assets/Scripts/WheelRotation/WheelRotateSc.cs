using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.UserInput;

namespace TopDownShooter.WheelRotate
{
    public class WheelRotateSc : MonoBehaviour
    {
        [SerializeField]
        InputManagerSet inputManagerSet;
        [SerializeField]
        WheelRotateSet wheelRotateSet;
        [SerializeField]
        Transform oneOfFrontWheel = null;
        
        void Start()
        {

        }

        void Update()
        {

            transform.Rotate(inputManagerSet.Vertical * wheelRotateSet.wheelRollingSpeed, 0/**speed*/, 0, Space.Self);
            //transform.rotation = Quaternion.Euler(inputManagerSet.Vertical * wheelRotateSet.wheelRollingSpeed, 0, 0);
            //transform.eulerAngles = new Vector3(transform.eulerAngles.x +inputManagerSet.Vertical * wheelRotateSet.wheelRollingSpeed, transform.rotation.y/**speed*/, 0);
            if (oneOfFrontWheel != null)
            {

                //Debug.Log(("local euler: "+oneOfFrontWheel.localEulerAngles.y));
                //Debug.Log(("normal euler: "+oneOfFrontWheel.eulerAngles.y));
                //Debug.Log(("normal rotation: "+oneOfFrontWheel.rotation.y));
                //Debug.Log(("local rotation: "+oneOfFrontWheel.localRotation.y));

                //if ( (oneOfFrontWheel.localEulerAngles.y<36 || oneOfFrontWheel.localEulerAngles.y>320))
                {
                    //oneOfFrontWheel.Rotate(0, inputManagerSet.Horizontal * wheelRotateSet.wheelRotationSpeed/**speed*/, 0);
                    oneOfFrontWheel.localEulerAngles = new Vector3(oneOfFrontWheel.localEulerAngles.x,0 + inputManagerSet.Horizontal * 16, oneOfFrontWheel.localEulerAngles.z);
                }
              

            }

        }
    }

}


