using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindBerry : MonoBehaviour
{

    public Sprite origin;
    public Sprite used;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = origin;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (GetComponent<SpriteRenderer>().sprite == origin)
        {
            GetComponent<AudioSource>().Play();   // play sound when clicking
            GetComponent<SpriteRenderer>().sprite = used;
            Debug.Log("You find some berries!");
            GameManager.instance.ConsumeFood();  //every move consume 1 food（reduce one food when enter this area）

            GameManager.instance.AddFood();
            Debug.Log("Food +1");

            GameManager.instance.FindBerry();
        }
        if (GetComponent<SpriteRenderer>().sprite == used)
        {


            Debug.Log("You cannot enter the same place twice!");

        }

    }
}
