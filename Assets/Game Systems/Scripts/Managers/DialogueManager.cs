using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //This shows the UI
    public bool showDlg;
    //This is the name of the character we are tlaking to
    public string charName;
    //These are the lines of text for our dialogue
    public string[] dialogue;
    //this is the line we are on...according to our array element value
    public int index;
    public void EndDialogue()
    {
        //hide the dialogue
        showDlg = false;
        //resets the conversation to the beginning
        index = 0;
        //puts the game back into the playing state
        GameManager.GameManagerInstance.gameState = GameStates.GameState;
    }
}
