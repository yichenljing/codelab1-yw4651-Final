﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassEvent : MonoBehaviour
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
            GetComponent<SpriteRenderer>().sprite = used;
            Debug.Log("You enter the grass area!");
            GameManager.instance.ConsumeFood();  //every move consume 1 food（reduce one food when enter this area）

        }

    }
}

