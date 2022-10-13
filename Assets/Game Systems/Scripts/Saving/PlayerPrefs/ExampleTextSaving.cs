using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO; //https://learn.microsoft.com/en-us/dotnet/api/system.io

public class ExampleTextSaving : MonoBehaviour
{
    //input valuies for saving
    public string[] whatWeAreSaving;
    //display what we have loaded after we split a string
    public string[] showWhatWeAreSplitting;
    //put some of the values into an array
    public string[] showStringsLoaded;
    //some of the values into an int
    public int showIntLoaded;

    //Path for saving and loading
    public string path = "Assets/Game Systems/Resources/Save/TextSaveFile.txt";
    /*void Example()
    {
        string path = Application.persistentDataPath + "TextSaveFile.txt";
        string path = Application.dataPath + "TextSaveFile.txt";
    }*/
    protected void Write()
    {
        //true adds on, false replaces
        StreamWriter writer = new StreamWriter(path,false);
        for (int i = 0; i < whatWeAreSaving.Length; i++)
        {
            //if its not the last piece of data
            if (i < whatWeAreSaving.Length-1)
            {
                //when saving add a marker | to seperate the data values
                writer.Write(whatWeAreSaving[i]+'|');
            }
            else //if we are at the last piece of data
            {
                //we don't need a marker | on the end as we are at the end so just save the data
                writer.Write(whatWeAreSaving[i]);
            }
        }
        //this lets us stop the data stream aka stop the process of saving so shiz don't break
        writer.Close();
        //this next part is only tied to Unity Editor
        AssetDatabase.ImportAsset(path);
        //what it does is allows if we have the save file selectedf and displaying in the inspector...the inspector updates when we save...else it doesn't look like shiz happens and that annys Jay :)
    }
    protected void Read()
    {
        StreamReader reader = new StreamReader(path);
        //temporarily store the loaded info
        string tempRead = reader.ReadLine();
        //splitting up the line at the marker | and putting each value into our array
        showWhatWeAreSplitting = tempRead.Split('|');
        //seperate our last value is the goal of the following

        //set our string array to the size of our splitted data minus the last piece of data...as that will be an int
        showStringsLoaded = new string[showWhatWeAreSplitting.Length - 1];
        //assign the string values to our array
        for (int i = 0; i < showStringsLoaded.Length; i++)
        {
            showStringsLoaded[i] = showWhatWeAreSplitting[i];
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Write();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Read();
        }
    }
}
