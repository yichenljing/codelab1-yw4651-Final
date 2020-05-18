using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Attack : MonoBehaviour
{
    public int attack;
    public int buff;
    public int damage;
    public int BossHealth;
    public GameObject attactResult;
    public GameObject attactButton;
    public Location location;
    public Menu menu;
    public AsciiLevelLoader level;
    // Start is called before the first frame update
    void Start()
    {
        BossHealth = 5;
        attack = Random.Range(1, 6);

        buff = GameManager.instance.power;
        Debug.Log("power = " + buff);
        damage = attack + buff;
       
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (damage >= BossHealth)
        {
            attactResult.GetComponent<Text>().text = ("You Win! \n You deal " + attack +"+" + buff+ "(Power) damage to the beast!");

                menu.changeScene("YouWin");

        }
        else {

            attactResult.GetComponent<Text>().text = ("You died! \n You deal " + attack + "+" + buff + "(Power) damage to the beast!\n" + "You are defeated by the beast!");
            menu.changeScene("DiedOfFight");
        }

    }

   
  

    public void afterAttact()
    {

        attactResult.SetActive(true);
    }
}

