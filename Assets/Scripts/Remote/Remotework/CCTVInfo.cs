using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class CCTVInfo : InteractableBase
    {
        public GameObject Info;
        
        public override void OnInteract()
        {
            base.OnInteract();

            Info.SetActive(true);
            
        }
    }
}