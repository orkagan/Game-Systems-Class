using System;
public class PlayerData
{
    public string characterName;
    //transform
    [Serializable]
    public struct Position
    {
        public float x, y, z;
    }
    public Position position;

    //rotation
    [Serializable]
    public struct Rotation
    {
        public float x, y, z, w;
    }
    public Rotation rotation;

    //other stats
    public PlayerData(PlayerHandler player)
    {
        characterName = player.name;

        position.x = player.transform.position.x;
        position.y = player.transform.position.y;
        position.z = player.transform.position.z;

        rotation.x = player.transform.rotation.x;
        rotation.y = player.transform.rotation.y;
        rotation.z = player.transform.rotation.z;
        rotation.w = player.transform.rotation.w;
    }
}
