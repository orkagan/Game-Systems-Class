using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickAudio : MonoBehaviour
{
    public AudioHandler _audioHandler;
    void Start()
    {
        foreach (Button button in GetComponentsInChildren<Button>())
        {
            button.onClick.AddListener(TaskOnClick);
        }
    }
    private void TaskOnClick()
    {
        _audioHandler.PlayClip();
    }
}
