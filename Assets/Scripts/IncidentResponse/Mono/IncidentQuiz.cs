using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncidentQuiz : MonoBehaviour
{

    public GameObject MainCanvas;
    public GameObject ResolutionCanvas;
    public GameObject AudioManager;
    private void OnEnable()
    {
        MainCanvas.SetActive(true);
        ResolutionCanvas.SetActive(true);
        AudioManager.SetActive(true);
    }
}
