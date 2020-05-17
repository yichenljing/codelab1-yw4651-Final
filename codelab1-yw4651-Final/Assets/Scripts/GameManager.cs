using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //making this the only insance
    public int CurrentScore = 0;
    public int CurrentFood = 5;  // start with 5 food
    public int CurrentPower = 0;

    public Text ScoreDisplay;
    public Text FoodDisplay;
    public Text PowerDisplay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ScoreDisplay.text = "Score: " + CurrentScore;
        FoodDisplay.text = "Food: " + CurrentFood;
        PowerDisplay.text = "Power: " + CurrentPower;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore ()
    {
        CurrentScore++;
        ScoreDisplay.text = "Score: " + CurrentScore;  //show current sccore text on screen
    }
    public void AddFood()
    {
        CurrentFood+= 2;
        FoodDisplay.text = "Food: " + CurrentFood;     //add 2 food
    }
    public void ConsumeFood()
    {
        CurrentFood--;
        FoodDisplay.text = "Food: " + CurrentFood;    //show current food amount on screen
    }
    public void AddPower()
    {
        CurrentPower ++;
        PowerDisplay.text = "Power: " + CurrentPower; //show current wood amount on screen

    }
}
