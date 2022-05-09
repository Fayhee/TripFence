using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VHS
{
    public class TurnOnNoise : InteractableBase
    {
        public GameObject audioInfo;
        public GameObject audioPlayer;
        public override void OnInteract()
        {
            base.OnInteract();

            audioInfo.SetActive(false);
            audioPlayer.SetActive(true);
        }
    }
}
