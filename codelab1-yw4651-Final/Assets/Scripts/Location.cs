using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : MonoBehaviour
{
    public GameObject UIlocation;
    public GameObject attackButton;
    public GameObject attactinfo;

    // Start is called before the first frame update
    void Start()
    {
        UIlocation.SetActive(false);
        attackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (UIlocation !=null) {
            if (GameManager.instance.Currentlocation == 1)
            {
                UIlocation.SetActive(true);
                //    if currentlocation ==1, the description changes to forest detail
                UIlocation.GetComponent<Text>().text = ("you enter the forest\n You got the power from the nature. \n Power +1 ");


            }

            if (GameManager.instance.Currentlocation == 2)
            {
                UIlocation.SetActive(true);
                UIlocation.GetComponent<Text>().text = ("Consume 2 food \n You enter the Badland.\n \n You consumed more food, but your Power seems to have increased under the harsh conditions of Badland\n\n  Power +1");
            }

            if (GameManager.instance.Currentlocation == 3)
            {
                UIlocation.SetActive(true);
                UIlocation.GetComponent<Text>().text = ("Consume 1 food \n You enter the Grass area.\n \n Nothing happens");
            }

            if (GameManager.instance.Currentlocation == 4)
            {
                UIlocation.SetActive(true);
                UIlocation.GetComponent<Text>().text = ("Consume 1 food \n\n  You enter the Mushroom area. \n \n Food+2");
            }

            if (GameManager.instance.Currentlocation == 5)
            {
                UIlocation.SetActive(true);
                UIlocation.GetComponent<Text>().text = ("Consume 1 food \n \n An evil Beast blocked the way");

                if (attactinfo.activeInHierarchy == false)
                {

                    attackButton.SetActive(true);

                }
                else if (attactinfo.activeInHierarchy == true)
                {
                    attackButton.SetActive(false);
                }


            }

            if (GameManager.instance.Currentlocation == 6)
            {
                UIlocation.SetActive(true);
                UIlocation.GetComponent<Text>().text = ("Consume 1 food \n\n  You enter the forest\n\n  You meet an elf in the forest, and you get extra power from him! \n \n Power+2");
            }

            if (GameManager.instance.Currentlocation == 7)
            {

                UIlocation.SetActive(true);

                UIlocation.GetComponent<Text>().text = ("Consume 1 food \n\n  You enter the Grass area.\n\n  You find some berries over the grass!  \n \n Food+1");
            }
        }



    }




}
