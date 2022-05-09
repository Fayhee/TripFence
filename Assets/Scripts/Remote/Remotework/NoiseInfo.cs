using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VHS
{
    public class NoiseInfo : InteractableBase
    {
        public GameObject audioInfo;

        public override void OnInteract()
        {
            base.OnInteract();

            audioInfo.SetActive(true);
        }
    }
}

