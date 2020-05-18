using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    public GameObject UIlocation;

    // Start is called before the first frame update
    void Start()
    {
        UIlocation.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.Currentlocation == 1)
        {
            UIlocation.SetActive(true);
            //    if currentlocation ==1, the description changes to forest detail
            UIlocation.GetComponent<Text>().text = ("you enter the forest.");
        
            
        }

        if (GameManager.instance.Currentlocation == 2)
        {
            UIlocation.SetActive(true);
            UIlocation.GetComponent<Text>().text = ("you enter the Badland.");
        }

        if (GameManager.instance.Currentlocation == 3)
        {
            UIlocation.SetActive(true);
            UIlocation.GetComponent<Text>().text = ("you enter the Grass area.");
        }

        if (GameManager.instance.Currentlocation == 4)
        {
            UIlocation.SetActive(true);
            UIlocation.GetComponent<Text>().text = ("you enter the Mushroom area.");
        }

        if (GameManager.instance.Currentlocation == 5)
        {
            UIlocation.SetActive(true);
            UIlocation.GetComponent<Text>().text = ("you meet the Boss.");
        }

        if (GameManager.instance.Currentlocation == 6)
        {
            UIlocation.SetActive(true);
            UIlocation.GetComponent<Text>().text = ("You cannot across the ocean.");
        }


    }





}
