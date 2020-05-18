using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEvent : MonoBehaviour
{
    public Sprite origin;
    public Sprite used;
    public Sprite notActive;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = notActive;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.power >= 3) {

            GetComponent<SpriteRenderer>().sprite = origin;
        }

    }

    void OnMouseDown()
    {
        if (GetComponent<SpriteRenderer>().sprite == origin)
        {

            GetComponent<AudioSource>().Play();   // play sound when clicking
            GetComponent<SpriteRenderer>().sprite = used;
           // Debug.Log("A evil Beast blocked the way");
            GameManager.instance.ConsumeFood();  //every move consume 1 food（reduce one food when enter this area）

            GameManager.instance.enterBoss();  //show detail text ui

        }
        if (GetComponent<SpriteRenderer>().sprite == used)
        {


            Debug.Log("You cannot enter the same place twice!");

        }
        else {

            Debug.Log("You are not powerful enough to enter this area! ");
        }

    }
}
