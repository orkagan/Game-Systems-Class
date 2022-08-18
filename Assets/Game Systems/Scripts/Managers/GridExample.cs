using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridExample : MonoBehaviour
{
    //IMGUI - Immdiate Mode GUI
    //https://docs.unity3d,com/Manual/GUIScriptingGuide.html
    //Events
    //https://docs.unity3d,com/ScriptReference/Event.html
    private void OnGUI()
    {
        for (int x = 0; x < 16; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                GUI.Box(new Rect(x * UIManager.scr.x, y * UIManager.scr.y, UIManager.scr.x, UIManager.scr.y),$"X:{x}\nY:{y}");
            }
        }
    }
}
