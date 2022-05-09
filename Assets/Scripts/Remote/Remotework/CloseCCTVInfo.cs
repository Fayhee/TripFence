using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class CloseCCTVInfo : InteractableBase
    {
        public GameObject Info;

        public override void OnInteract()
        {
            base.OnInteract();

            Info.SetActive(false);

        }
    }
}