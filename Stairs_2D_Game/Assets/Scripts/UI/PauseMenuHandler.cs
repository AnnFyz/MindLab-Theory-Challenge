using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuHandler : MonoBehaviour
{
    [SerializeField] int sceneToLoad = 1;
    [SerializeField] GameObject Panel;
    //[SerializeField] GameObject Logos;
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

    void TogglePanel()
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
    public void ActivatePanel()
    {
        Panel.SetActive(true);
    }

    public void DeactivatePanel()
    {
        Panel.SetActive(false);
    }
}
