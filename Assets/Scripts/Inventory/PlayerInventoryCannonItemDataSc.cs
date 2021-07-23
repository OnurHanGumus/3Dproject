using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Lessons/Lessons1/playerCannon ItemData")]
    public class PlayerInventoryCannonItemDataSc : AbstractPlayerInventoryItemData<PlayerInventoryCannonMONO>
    {
        public float damage;
        [SerializeField] float rpm = 1f;
        [SerializeField] float lastShootTime = 0f;
        public float RPM { get { return rpm; } }
        public override void Initialize(PlayerInventorySc targetPlayerInventorySc)
        {
            base.Initialize(targetPlayerInventorySc);
            var instantiated = InstantiatePrefabIntoParent(targetPlayerInventorySc.Parent);
            targetPlayerInventorySc.reactiveShootCommand.Subscribe(OnReactiveShootCommand).AddTo(disposables) ;
            Debug.Log("THis class Cannon of Player");

        }

        private void OnReactiveShootCommand(Unit obj)
        {
            Debug.Log("reactive command shoot");
            Shoot();
        }

        public override void Destroy()
        {
            base.Destroy(); 
        }

        public void Shoot()
        {
            if (Time.time - lastShootTime> rpm)
            {
                instantiated.Shoot();
                lastShootTime = Time.time;
            }
            else
            {
                Debug.Log("cant shoot now");
            }

        }
    }

   


}
