using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePlayerPrefsSaving : MonoBehaviour
{
    /*
    Pros
        - Prebuilt
            - Already has all the functions and functionality
            - Easy to use
        - Saves a Key (name) and Value(data) similar to a dictionary
        - Easy to edit
    Cons
        - Not Flexible (only saves Float, Int, String)
        - Easy to edit - Players can easily mess with the file
        - WebPlayer has a playerPrefs size limit of 1MB

    What is it good for?
        - User/Optinos/Settings
    */

    public string savedInfo;
    void Awake()
    {
        if (PlayerPrefs.HasKey("Test String"))
        {
            //if there is data called Test String
            Debug.Log("Data was found :D");
        }
        else
        {
            //there is no data called Test String
            Debug.Log("404 save file not found :(");
        }
    }
    void Start()
    {
        //Returns the value corresponding to key in the preference file if it exists
        savedInfo = PlayerPrefs.GetString("Test String", "Crisp Rat");
    }

    void Update()
    {
        //Save
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Set = Write = Save
            //Sets the value of the preference identified by key.
            PlayerPrefs.SetString("Test String", savedInfo);
            //
            PlayerPrefs.SetInt("Test Int", 1);
            PlayerPrefs.SetFloat("Test Float", 1f);
            //Writes all modified preferences to disk
            PlayerPrefs.Save();
            //https://docs.unity3d.com/ScriptReference/PlayerPrefs.Save.html
        }
        //Delete String
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Removes key and its corresponding value from the preferences.
            PlayerPrefs.DeleteKey("Test String");
        }
        //Delete All
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Removes all keys and values from the references. Use with caution.
            PlayerPrefs.DeleteAll();
        }
    }
}
