using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BadLandEvent : MonoBehaviour
{
    
    public Sprite origin;
    public Sprite used;

    public Text LocationDetail;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = origin;

       // location = GameObject.Find("BadlandPanel");
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
            Debug.Log("You enter the BadLand!");
            GameManager.instance.ConsumeFood();  //every move consume 1 food（reduce one food when enter this area）
            GameManager.instance.ConsumeFood(); //BadLand needs one more food
            GameManager.instance.AddPower();
            Debug.Log("You consumed more food, but your Power seems to have increased under the harsh conditions of Badland!");
            GameManager.instance.enterBadland();


            // Instantiate(location, new Vector3(400, 400, 0), Quaternion.identity);
            // GetComponent<DirectionManager>().UpdateLocation(1);

        }
        else if (GetComponent<SpriteRenderer>().sprite == used)
        {


            

        }


    }


}
