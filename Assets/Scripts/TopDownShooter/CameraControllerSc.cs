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

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(targetTransform.forward), Time.deltaTime * cameraControllerSet.RotationSpeed);


        }

        void CameraFollow()
        {
            Vector3 offset = (transform.right * cameraControllerSet.Offset.x) + (transform.up * cameraControllerSet.Offset.y)
                + (transform.forward * cameraControllerSet.Offset.z);
            transform.position = Vector3.Lerp(transform.position, targetTransform.position + offset, Time.deltaTime * cameraControllerSet.PositionLerp);


        }
    }


}
