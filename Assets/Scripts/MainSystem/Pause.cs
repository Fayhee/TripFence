using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button resumeButton;

    void Awake()
    {
        pauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(OnResumePressed);

        Time.timeScale = 1;
    }

    public void OnResumePressed()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

    }

    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Quit()
    {
        Application.Quit(0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            pauseMenu.SetActive(true);
           
            Time.timeScale = 0;
        }
    }
}



