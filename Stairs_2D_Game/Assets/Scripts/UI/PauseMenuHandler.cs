using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuHandler : MonoBehaviour
{
    [SerializeField] int sceneToLoad = 1;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject menuButton;
    private void Start()
    {
        DeactivatePanel();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab))
        {
            TogglePanel();
        }
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void TogglePanel()
    {
        if (Panel.activeSelf)
        {
            DeactivatePanel();
        }
        else
        {
            ActivatePanel();
        }
    }
    void ActivatePanel()
    {
        Panel.SetActive(true);
        menuButton.SetActive(false);
    }

    void DeactivatePanel()
    {
        Panel.SetActive(false);
        menuButton.SetActive(true);
    }
}
