using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class PlayerBinary
{
    public static void SaveData(PlayerHandler player)
    {
        //Reference to our binary formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //Location to save (aka out path)
        string path = Application.persistentDataPath + "/" + "Flower_Texture" + ".jpeg";
        //Create/Replace a file at that fire path
        FileStream writeDataStream = new FileStream(path, FileMode.Create);
        //What data to write the file
        PlayerData data = new PlayerData(player);
        //Write that data from the serialized byte stream (aka the Unity data that we have converted so we can save it to the file...writing is saving)
        formatter.Serialize(writeDataStream, data);
        //and we are done with the action so close the byte stream and finish writing
        writeDataStream.Close();
    }
    public static PlayerData LoadData(PlayerHandler player)
    {
        //location of save (aka our path)
        string path = Application.persistentDataPath + "/" + "Flower_Texture" + ".jpeg";
        //if we have a file at that path
        if (File.Exists(path))
        {
            //Reference to our binary formatter
            BinaryFormatter formatter = new BinaryFormatter();
            //Open the file at the file path
            FileStream readDataStream = new FileStream(path, FileMode.Open);
            //read that data fromo the file and deserialize the bytes in the stream (aka turn the Unity data that we have converted into bytes during saving, back into C# data for Unity to use...reading is loading)
            PlayerData data = formatter.Deserialize(readDataStream) as PlayerData;
            //and we are done with the action so close the byte stream and finish reading
            readDataStream.Close();
            //send the usable data to the PlayerData script
            return data;
        }
        return null;
    }
}
