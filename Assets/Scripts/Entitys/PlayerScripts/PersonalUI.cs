using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class PersonalUI 
{
    Player owner;
    public Slider HealthBar { get; set; }
    public Slider ManaBar { get; set; }
    public Slider XpBar { get; set; }
    public Slider ExpBar { get; set; }
    public Slider StaminaBar { get; set; }
    public Sprite PlayerImage { get; set; }
    public int health;
    public int mana;
    int xp;
    int stamina;
    int exp;

    public int currentHealth;
    public int CurrentMana;
    int CurrentXp;
    int Currentstamina;
    int currentExp;
    public PersonalUI(Player _owner)
    {
       
        HealthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<Slider>();
        ManaBar = GameObject.FindGameObjectWithTag("ManaBar").GetComponent<Slider>();
        XpBar= GameObject.FindGameObjectWithTag("XpBar").GetComponent<Slider>();
        StaminaBar = GameObject.FindGameObjectWithTag("StaminaBar").GetComponent<Slider>();
        ExpBar = GameObject.FindGameObjectWithTag("ExpBar").GetComponent<Slider>();
        PlayerImage = GameObject.FindGameObjectWithTag("PlayerImage").GetComponent<Sprite>();
       
        owner = _owner;
        health = owner.MaximumLife;
        exp = LevelManager.RequiredExperience(owner.Level);
        
        mana = owner.MaximumMana;

        xp = owner.MaximumXp;
        stamina = owner.MaximumXp;

        currentExp = owner.Experience;
        currentHealth = owner.CurrentLife;
        CurrentMana = owner.Character.Mana;
        Debug.Log(mana);
        CurrentXp = owner.Xp;
        Currentstamina = owner.Character.Stamina;


}
    public void UpdateHealth()
    {
       currentHealth = owner.CurrentLife;
        HealthBar.value = CalculateHealth();

    }
    public float CalculateHealth()
    {

        return (float) owner.CurrentLife/ health;

    }


    public void UpdateMana()
    {
        Debug.Log(CurrentMana + " " + owner.Mana);
        CurrentMana = owner.Character.Mana;

        ManaBar.value = CalculateMana();

    }
    public float CalculateMana()
    {

        return (float)CurrentMana / mana;

    }

    public void UpdateStamina()
    {
       Currentstamina = owner.Character.Stamina;
        StaminaBar.value = CalculateStamina();

    }
    public float CalculateStamina()
    {

        return (float)Currentstamina / stamina;

    }


    public void UpdateXP()
    {
        CurrentXp = owner.Xp;
        XpBar.value = CalculateXp();

    }
    public float CalculateXp()
    {

        return (float)Currentstamina / stamina;

    }

    public void UpdateExp()
    {
        currentExp = owner.Experience;
      ExpBar.value = CalculateExp();

    }
    public float CalculateExp()
    {

        return (float)currentExp / exp;

    }


    public void PlayerImageUpate(Sprite image)
    {
        PlayerImage = image;
    }
}
