using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
   public PlayerMovement movement;
    public CameraController cam;
    // character personal stats;
    public PC Character;
    
    //Player Personal info
    public override int MaximumLife => combatStats.MaxLife + Character.Life;
    public override int CurrentLife { get => base.CurrentLife; set => base.CurrentLife = value; }
    public override string EntityName { get { return Character.Name; } set { Character.Name = value; } }

    public override int Level
    { get { return Character.Level; } set { Character.Level = value; Character.Level = value; } }
    public int Money { get { return Character.Money; } set { Character.Money = value; } }
    public int BankMoney { get { return Character.BankMoney; } set { Character.BankMoney = value; } }
    public int Gem { get { return Character.Gem; } set { Character.Gem = value; } }
    public int Experience { get { return Character.Experience; } set { Character.Experience = value; } }
    public int Strength { get { return Character.Strength; } set { Character.Strength = value; } }
    public int Vitality { get { return Character.Vitality; } set { Character.Vitality = value; } }
    public int Agility { get { return Character.Agility; } set { Character.Agility = value; } }
    public int Intellect { get { return Character.Intellect; } set { Character.Intellect = value; } }
    public int ExtraStats { get { return Character.ExtraStats; } set { Character.ExtraStats = value; } }



    // Start is called before the first frame update
    void Start()
    {
        Level = 1;
        CurrentLife = MaximumLife;
        movement = new PlayerMovement(this.gameObject);
        cam = new CameraController(this.transform);
        Debug.Log(CurrentLife);
    }

    // Update is called once per frame
   void Update()
    {
       
        
        
      
    }
    private void FixedUpdate()
    {
        cam.CameraMovement();
        movement.MovePlayer();
    }

    public void damage(int amount)
    {
        CurrentLife -= amount;Debug.Log(CurrentLife);
    }


}
