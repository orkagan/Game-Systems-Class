using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    //Array Reference
    public GameObject[] panels;
    public MenuStates menuState;
    public void Start()
    {
        ChangePanel(menuState);
    }
    public void Update()
    {
        switch (menuState)
        {
            case MenuStates.AnyKey:
                if (Input.anyKey) ChangePanel(MenuStates.Menu);
                break;
            case MenuStates.Menu:
                break;
            case MenuStates.Options:
                break;
            default:
                break;
        }
    }
    public void ChangePanel(int newState)
    {
        ChangePanel((MenuStates)newState);
    }
    public void ChangePanel(MenuStates newState)
    {
        menuState = newState;
        for(int i=0; i<panels.Length; i++)
        {
            if ((int)menuState == i)
            {
                panels[i].SetActive(true);
            }
            else
            {
                panels[i].SetActive(false);
            }
        }
    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        Debug.Log("ExitGame attempted.");
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

public enum MenuStates
{
    AnyKey,
    Menu,
    Options
}
