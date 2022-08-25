using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneChoice : DialogueManager
{
    [Header("Choice Marker")]
    public int choiceIndex;
    private void OnGUI()
    {
        //if our dialogue can be seen on screen
        if (showDlg)
        {
            //the diaglogue box takes up the whole bottom 3rd of the screen
            /*...this box also displays the NPC name and current line of dialogue*/
            GUI.Box(new Rect(0, UIManager.scr.y * 6, UIManager.scr.x * 16, UIManager.scr.y * 3), $"{charName}: {dialogue[index]}");
            //if we are not yet at the end of dialogue AND we are not the choice index
            if (index < dialogue.Length - 1 && index!=choiceIndex)
            {
                //display a button that says next in the bottom right area somewhere of the screen and if its pressed ...then
                if (GUI.Button(new Rect(UIManager.scr.x * 13.5f, UIManager.scr.y * 8.25f, UIManager.scr.x * 2.5f, UIManager.scr.y * 0.75f), "Next"))
                {
                    //increase index by 1
                    index++;
                }
            }
            else if (index == choiceIndex)
            {
                if (GUI.Button(new Rect(UIManager.scr.x * 10.5f, UIManager.scr.y * 8.25f, UIManager.scr.x * 2.5f, UIManager.scr.y * 0.75f), "Yes"))
                {
                    index++;
                }
                if (GUI.Button(new Rect(UIManager.scr.x * 13.5f, UIManager.scr.y * 8.25f, UIManager.scr.x * 2.5f, UIManager.scr.y * 0.75f), "No"))
                {
                    index = dialogue.Length - 1;
                }
            }
            //else we are on the last line of dialogue
            else
            {
                //display bye button where next was and if triggered
                if (GUI.Button(new Rect(UIManager.scr.x * 13.5f, UIManager.scr.y * 8.25f, UIManager.scr.x * 2.5f, UIManager.scr.y * 0.75f), "Goodbye"))
                {
                    //run parent End DLG code
                    EndDialogue();
                }
            }
        }
    }

}
