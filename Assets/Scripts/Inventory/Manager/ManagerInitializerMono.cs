using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class ManagerInitializerMono : MonoBehaviour
    {
        [SerializeField] private AbstractScriptableBaseSc[] abstractScriptableBaseArray;
        private List<AbstractScriptableBaseSc> instantiatedManagerList;

        void Start()
        {
            instantiatedManagerList = new List<AbstractScriptableBaseSc>(abstractScriptableBaseArray.Length);
            for (int i = 0; i < abstractScriptableBaseArray.Length; i++)
            {
                var instantiated = Instantiate(abstractScriptableBaseArray[i]);
                instantiated.Initialize();
                instantiatedManagerList.Add(instantiated);

            }


        }

        private void OnDestroy()
        {
            if (instantiatedManagerList !=null)
            {
                for (int i = 0; i < instantiatedManagerList.Count; i++)
                 {
                     instantiatedManagerList[i].Destroy();
                 }
            }
            

        }
    }


}
