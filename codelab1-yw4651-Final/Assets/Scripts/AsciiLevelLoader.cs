using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class AsciiLevelLoader : MonoBehaviour
{
    public GameObject grass;
    public GameObject forest;
    public GameObject ocean;
    public GameObject mushroom;
    public GameObject badland;
    public GameObject Boss;
    public GameObject GrassElf;
    public GameObject Berries;


    public float xOffset = 0f;
    public float yOffset = 0;

    public string fileLevel = "Level.txt"; 

    // Start is called before the first frame update
    void Start()
    {
        string fullFilePath = Application.dataPath + "/" + fileLevel;

        print("Full file path: " + fullFilePath);

        print(File.ReadAllText(fullFilePath));

        //lines will be an array of strings, with each line in a different slot
        string[] lines = File.ReadAllLines(fullFilePath);

        //Make a GameObject to hold all the walls to make the inspector cleaner
        GameObject wallHolder = new GameObject("terrain Holder");

        //go through all the lines
        for (int y = 0; y < lines.Length; y++){
            string line = lines[y]; //get each line

            char[] characters = line.ToCharArray();

            //go through each character on the current line
            for (int x = 0; x < characters.Length; x++){
                GameObject newObject;

                switch(characters[x])
                {
                    case 'G':
                        newObject = Instantiate<GameObject>(grass);
                        newObject.transform.SetParent(wallHolder.transform); 
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'F':
                        newObject = Instantiate<GameObject>(forest);
                        newObject.transform.SetParent(wallHolder.transform); 
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;


                    case 'O':
                        newObject = Instantiate<GameObject>(ocean);
                        newObject.transform.SetParent(wallHolder.transform);
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'M':
                        newObject = Instantiate<GameObject>(mushroom);
                        newObject.transform.SetParent(wallHolder.transform); //make the parent of th new terrrain
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'B':
                        newObject = Instantiate<GameObject>(badland);
                        newObject.transform.SetParent(wallHolder.transform); 
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'I':
                        newObject = Instantiate<GameObject>(Boss);
                        newObject.transform.SetParent(wallHolder.transform); 
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;


                    case 'E':
                        newObject = Instantiate<GameObject>(GrassElf);
                        newObject.transform.SetParent(wallHolder.transform);
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    case 'D':
                        newObject = Instantiate<GameObject>(Berries);
                        newObject.transform.SetParent(wallHolder.transform);
                        newObject.transform.position =
                                new Vector2(x + xOffset, -y + yOffset);
                        break;

                    default:
                        print("empty");
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
