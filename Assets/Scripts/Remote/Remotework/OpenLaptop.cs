using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace VHS
{
    public class OpenLaptop : InteractableBase
    {

        public override void OnInteract()
        {
            base.OnInteract();

            SceneManager.LoadScene("LoadingScene");
        }
    }
}


