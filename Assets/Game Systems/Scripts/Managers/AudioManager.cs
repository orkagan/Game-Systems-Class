using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _audioManager;
    public static AudioManager AudioManagerInstance
    {
        get => _audioManager;
        private set
        {
            if (_audioManager == null)
            {
                _audioManager = value;
            }
            else if (_audioManager != value)
            {
                Debug.Log($"{nameof(AudioManager)} instance already exists, destroy the imposter!");
                Destroy(value.gameObject);
            }
        }
    }
    private void Awake()
    {
        AudioManagerInstance = this;
        DontDestroyOnLoad(this.gameObject); //don't destroy on scene change
    }
}
