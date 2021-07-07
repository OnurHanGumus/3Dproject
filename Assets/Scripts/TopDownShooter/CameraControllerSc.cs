using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    public class CameraControllerSc : MonoBehaviour
    {

        [SerializeField]
        CameraControllerSet cameraControllerSet;
        [SerializeField]
        Transform targetTransform;
        
        void Update()
        {
            CameraRotate();
            CameraFollow();
        }

        void CameraRotate()
        {

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(targetTransform.position - transform.position), Time.deltaTime * cameraControllerSet.RotationSpeed);


        }

        void CameraFollow()
        {

            transform.position = Vector3.Lerp(transform.position, targetTransform.position + cameraControllerSet.Offset, Time.deltaTime * cameraControllerSet.PositionLerp);


        }
    }


}
