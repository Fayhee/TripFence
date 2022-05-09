using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteIntro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject start;
    public GameObject player;
    public GameObject audioP;
    public GameObject cam;
    private void OnEnable()
    {
        start.SetActive(true);
        player.SetActive(true);
        audioP.SetActive(false);
        cam.SetActive(false);


    }
}
