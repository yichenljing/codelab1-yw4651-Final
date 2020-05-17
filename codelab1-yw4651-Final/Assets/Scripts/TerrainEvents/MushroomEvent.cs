using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MushroomEvent : MonoBehaviour
{
    public Sprite origin;
    public Sprite used;   //the sprite to replace the place that you already been to；
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
      
        if (GetComponent<SpriteRenderer>().sprite == origin) {
            GetComponent<SpriteRenderer>().sprite = used;
            //replace the sprite
            Debug.Log("You enter an area full of mushroom!");
            GameManager.instance.ConsumeFood();  //every move consume 1 food（reduce one food when enter this area）

            GameManager.instance.AddFood();
            Debug.Log("Your Food: " + GameManager.instance.CurrentFood);
            
        }
        else if (GetComponent<SpriteRenderer>().sprite == used)
        {


            Debug.Log("You already been there, try another place."); 

        }
       
       
    }
}