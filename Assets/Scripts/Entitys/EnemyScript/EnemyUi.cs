using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class EnemyUi 
{
    Monster owner;
    [SerializeField]
    public Slider HealthBar;
    int health;
    int currentHealth;
    public Text name;
    
    public enum levelBonus
        {
         green,
         red,
         black,
         white
        }

    public EnemyUi(Monster _owner)
    {

        owner = _owner;
        health = _owner.MaximumLife;
        currentHealth = owner.CurrentLife;
        HealthBar = _owner.gameObject.transform.Find("NPC_Enemy/HealthBarSlider").GetComponent<Slider>();
        name = _owner.gameObject.transform.Find("NPC_Enemy/NameText").GetComponent<Text>();
        name.color = Color.red;
        HealthBar.value = CalculateHealth();
        
//HealthBar.value = CalculateHealth();

    }

   

    public void UpdateUi()
    {
        currentHealth = owner.CurrentLife;
        Debug.Log(currentHealth);
        HealthBar.value = CalculateHealth();
    }



   public float CalculateHealth()
    {
        Debug.Log(" " + currentHealth  +" " + health);
        return (float)currentHealth / health;
     
    }

    
}
