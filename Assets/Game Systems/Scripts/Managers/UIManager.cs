using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //ref to out screens x and y divided by out aspect ratio
    public static Vector2 scr;

    //Singleton
    private static UIManager _uiManagerInst;
    public static UIManager UIManagerInstance 
    {
        //lambda operator for funzies
        get => _uiManagerInst;
        private set
        {
            //if there is no reference
            if (_uiManagerInst==null)
            {
                //set out reference to this instance
                _uiManagerInst = value;
            }
            //else if instance is not the same instance as the value
            else if (_uiManagerInst!=value)
            {
                //Debug
                Debug.Log($"{nameof(UIManager)} instance already exists, destroy the duplicate!");
                //Eliminate imposters
                Destroy(value);
            }
        }
    }
    private void Awake()
    {
        UIManagerInstance = this;
    }
    public void UpdateUIScale()
    {
        if (new Vector2(Screen.width/16,Screen.height/9) != scr)
        {
            scr.x = Screen.width / 16;
            scr.y = Screen.height / 9;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateUIScale();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUIScale();
    }
}
