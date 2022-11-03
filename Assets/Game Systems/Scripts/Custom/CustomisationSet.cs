using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class CustomisationSet : MonoBehaviour
{
    #region Variables
    public string charName;
    public Dictionary<string,List<Texture2D>> textures = new Dictionary<string, List<Texture2D>>();
    public Dictionary<string,int> textureIndex = new Dictionary<string, int>();
    public MeshRenderer charMeshRen;
    public string[] materialNames = new string[6]
    { "Skin","Mouth","Eyes","Hair","Clothes","Armour"};
    ///
    public bool raceDDVisible;
    public string raceDropDisplay = "Select Race";
    //public Dropdown raceDD;

    public bool classDDVisible;
    public string classDropDisplay = "Select Class";
    //public Dropdown classDD;

    public Vector2 scrollPosRace, scrollPosClass;
    public int bonusStatPoints = 6;
    public string[] attributeName = new string[3]
    { "Health", "Mana", "Stamina" };
    public string[] statName = new string[6]
    { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
    #endregion
    #region Start/Setup
    private void Start()
    {
        #region forloops to pull textures from Resources
        foreach(string materialName in materialNames)
        {
            Debug.Log(materialName);
            for(int i=0; i>=0; i++)
            {
                Texture2D temp = Resources.Load($"Character/{materialName}_{i}") as Texture2D;
                if (temp == null) break;
                if (textures.ContainsKey(materialName))
                {
                    textures[materialName].Add(temp);
                }
                else
                {
                    textures.Add(materialName, new List<Texture2D>() { temp });
                }
                Debug.Log($"textures[{materialName}] = {textures[materialName][i]}");
            }
        }
        #endregion
        #region We do this section after set texture
        #endregion
    }
    #endregion

    #region Set Texture Behaviour
    public void SetTexture(string type, int dir)
    {
        int index = 0, max = 0, matIndex = 0;
        MeshRenderer curRend = new MeshRenderer();
        Texture2D[] textures = new Texture2D[0];
        #region Switch Material
        switch (type)
        {
            case "Skin":
                //index = skinIndex;
                break;
            default:
                break;
        }
        #endregion
        #region Assign Direction
        #endregion
        #region Switch Set Material to Model
        #endregion
    }
    #endregion
}
