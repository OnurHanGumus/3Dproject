using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.UserInput;


namespace TopDownShooter.PlayerMovement
{
    public class TowerRotationSc : MonoBehaviour
    {
        [SerializeField] InputManagerSet inputManagerSet;
        [SerializeField] TowerRotationSet towerRotationSet;
        [SerializeField] Transform towerTransform;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            towerTransform.Rotate(0,inputManagerSet.HorizontalTower*towerRotationSet.towerRotationSpeed,0,Space.Self);
        }
    }
 
}

