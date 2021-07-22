using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class PlayerInventorySc : MonoBehaviour
    {
        [SerializeField] AbstractBasePlayerInventoryData[] inventoryItemPlayerInventoryArray;
        // Start is called before the first frame update
        public Transform Parent;
        private List<AbstractBasePlayerInventoryData> createdItemDataList;
        void Start()
        {
           
            InitializeInventory(inventoryItemPlayerInventoryArray);
            
        }

        void OnDestroy()
        {
            ClearInventory();

        }

        public void InitializeInventory(AbstractBasePlayerInventoryData[] abstractPlayerInventoryItemDatas)
        {
            ClearInventory();
            createdItemDataList = new List<AbstractBasePlayerInventoryData>(inventoryItemPlayerInventoryArray.Length);
            for (int i = 0; i < inventoryItemPlayerInventoryArray.Length; i++)
            {
                var instantied = Instantiate(inventoryItemPlayerInventoryArray[i]);
                inventoryItemPlayerInventoryArray[i].CreateIntoInventory(this);
                createdItemDataList.Add(instantied);
            }

        }

        private void ClearInventory()
        {
            if (createdItemDataList!=null)
            {
                for (int i = 0; i < createdItemDataList.Count; i++)
                {
                    createdItemDataList[i].Destroy();
                }
            }

        }
    }


}
