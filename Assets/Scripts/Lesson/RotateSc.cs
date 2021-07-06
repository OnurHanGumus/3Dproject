using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateSc : MonoBehaviour
    {
        // Start is called before the first frame update
        
        [SerializeField]
        RotateSet rotateSet;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up * rotateSet.Speed * Time.deltaTime);
        }

    }

}
