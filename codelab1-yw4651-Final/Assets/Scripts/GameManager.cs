using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //making this the only insance
    public int CurrentScore = 0;
    public int CurrentFood = 5;  // start with 5 food
    public int CurrentPower = 0;
    public int power;
    public int Currentlocation =0;  

    public Text ScoreDisplay;
    public Text FoodDisplay;
    public Text PowerDisplay;

   // public Text LocationDisplay;

    public string title; // var for title
    public string description; // var for a desription

    public Menu menu;
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
  /*  public void ShowLocation()

    {
        LocationDisplay.text = "" + title + description;

    }
    */

    // Update is called once per frame
    void Update()
    {
        power = CurrentPower;
    }

    public int getPower() {

        return power;
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
        if (CurrentFood >= 1)
        {

            CurrentFood--;
            FoodDisplay.text = "Food: " + CurrentFood;    //show current food amount on screen
        }
        else {
            menu.changeScene("GameMenu");
        }
      
    }
    public void AddPower()
    {
        CurrentPower ++;
     

        PowerDisplay.text = "Power: " + CurrentPower; //show current wood amount on screen

    }

    public void enterForest()
    {
        Currentlocation = 1;

    }
    public void enterBadland()
    {
        Currentlocation = 2;

    }
    public void enterGrass()
    {
        Currentlocation = 3;

    }
    public void enterMushroom()
    {
        Currentlocation = 4;

    }
    public void enterBoss()
    {
        Currentlocation = 5;

    }
    public void MetElf()
    {
        Currentlocation = 6;

    }
    public void FindBerry()
    {
        Currentlocation = 7;

    }
}
