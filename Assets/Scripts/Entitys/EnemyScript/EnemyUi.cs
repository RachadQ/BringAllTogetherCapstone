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
   
    [SerializeField]
    FloatingText popUpText;
    [SerializeField]
    GameObject canvas;

 
    public EnemyUi(Monster _owner)
    {

        owner = _owner;
        health = _owner.MaximumLife;
        currentHealth = owner.CurrentLife;
        HealthBar = _owner.gameObject.transform.Find("NPC_Enemy/HealthBarSlider").GetComponent<Slider>();
        name = _owner.gameObject.transform.Find("NPC_Enemy/NameText").GetComponent<Text>();
        name.text = owner.EntityName;
        name.color = Color.red;
        HealthBar.value = CalculateHealth();

        canvas = owner.gameObject.transform.Find("NPC_Enemy").gameObject;
      
        if (!popUpText)
            popUpText = Resources.Load<FloatingText>("PopUpUi/PopUpTextParent");

        //HealthBar.value = CalculateHealth();

    }


   

    public void UpdateUi()
    {
        currentHealth = owner.CurrentLife;
        //set enemy Health bar to calculated health aka percentage
        HealthBar.value = CalculateHealth();
    }

    public void CreateFloatingText(string text, Transform location)
    {

        //instatiate popuptext
        FloatingText instance = MonoBehaviour.Instantiate(popUpText);
        ;
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(location.position);
        screenPosition.y += 25;
        Vector3 canvasPos = canvas.transform.position;
        canvasPos.y += 1;
        //set parent
        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = canvasPos;
        instance.SetText(text);
    }

    public float CalculateHealth()
    {

        return (float)currentHealth / health;
     
    }

    
}
