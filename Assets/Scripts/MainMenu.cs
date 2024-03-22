using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject optionsPanel;

    public void GoToMain ()
    {
        mainPanel.SetActive(true);
        optionsPanel.SetActive(false);

    }

    public void GoToOptions()
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(true);

    }

    public void OnPlayClicked ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
    }
}
