﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity, IRespawn
{
    public QuestSystem quests;
    
    public PlayerMovement movement;
    public CameraController cam;
    // character personal stats;
    public PC Character;
    public StatusInfo statusUi;
    public Guild guild;
    public PersonalUI personalUi;
    public Inventory inventory;

    public float time { get; set; }
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
    public bool LevelUp{ get; set; }
    public float SpawnRate;

    private void Awake()
    {
        Level = 1;
        cam = new CameraController(this.transform);
        movement = new PlayerMovement(this.gameObject);
       
        personalUi = new PersonalUI(this);
        statusUi = new StatusInfo(this);
        quests = new QuestSystem();
       
        
        inventory = new Inventory(this);
        inventory.UpdateGoldUi();
    

    }


    // Start is called before the first frame update
    void Start()
    {
     
        Character.ExtraStats = 10;
       // Debug.Log(MaximumMana + "mana");
        
       
      
        CurrentLife = MaximumLife;
        personalUi.UpdateExp();
        personalUi.UpdateMana();
        personalUi.UpdateStamina();
        //  UpdateAllBars();
      
        //quests.AddQuest();
    }

    public void UpdateAllBars()
    {
        personalUi.UpdateHealth();
        personalUi.UpdateExp();
        personalUi.UpdateMana();
        personalUi.UpdateStamina();
        personalUi.UpdateXP();
    }

    RaycastHit hit;
  
    // Update is called once per frame
    void Update()
    {
      
         
        if (Input.GetKeyDown(KeyCode.R))
        {
           
            personalUi.UpdateHealth();
        }

        Respawn(SpawnRate);

        
    }
    private new void FixedUpdate()
    {
        movement.MovePlayer();
        cam.CameraMovement();
        
    }


    public void teleport(GameObject location)
    {
        this.gameObject.transform.position = location.transform.position;
    }
        
    public void GainExperience(int _exp)
    {
        //if max level just return
        LevelUp = false;
        this.Experience += _exp * 1;
        Debug.Log("pLAYER HAVE " + Character.Experience + " Character needs " + LevelManager.RequiredExperience(Character.Level));
        
        personalUi.UpdateExp();
        // && Character experience is equal to require experience
        while (Character.Level < 10 && this.Experience >= LevelManager.RequiredExperience(Character.Level))
        {

            LevelUp = true;
            this.Experience -= LevelManager.RequiredExperience(Level);
            Debug.Log(Experience);
            Level++;
           
            Character.ExtraStats += 10;
            Debug.Log(Character.Level);
        }
        if (LevelUp == true)
        {
            SetLevel(Level);
            LevelUp = false;
            Debug.Log(Level);
        }
       
    }


    public void Respawn(float Spawn)
    {

        if (!Alive)
        {

            time += Time.deltaTime * 1;


            if (time > Spawn)
            {
                //spawn is bug
                time = 0;
                CurrentLife = MaximumLife;
                this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
                this.gameObject.GetComponent<Renderer>().enabled = true;

               
                personalUi.UpdateHealth();

            }


        }

    }

    public void SetLevel(int _level)
    {
        Level = _level;
        Debug.Log(LevelManager.RequiredExperience(Level));
        EventManager.TriggerEvent("lvl");
        EventManager.TriggerEvent("UpStat");
        //CurrentLife = MaximumLife;
        
        //ReCalculate(true);
    }

    void OnEnable()
    {
        EventManager.StartListening("UpStat", UpdateStats);
        EventManager.StartListening("lvl", UpdateLevel);
        //    EventManager.StartListening("InvClick",);
    }
    void OnDisable()
    {
        EventManager.StopListening("Upstat", UpdateStats);
        EventManager.StopListening("lvl", UpdateLevel);

    }
    public void UpdateLevel()
    {
        statusUi.UpdateLevel();
    }

    public void UpdateHealth(int amount)
    {

        RecieveDamage(amount);
        personalUi.UpdateHealth();


    }
    #region attribute
    private void UpdateStats()
    {
        statusUi.UpdateStrText();
        statusUi.UpdateIntText();
        statusUi.UpdateAgiText();
        statusUi.UpdateVitText();
        statusUi.UpdateExtrText();
    }
  
    public void PointsOnStrength()
    {
       
        if (ExtraStats <= 0)
            return;
        Character.Strength += 1;
        Character.ExtraStats -= 1;
        if (Character.ExtraStats <= 0)
        {
            Character.ExtraStats = 0;
        }
        EventManager.TriggerEvent("UpStat");
        //Debug.Log("trigger");
        //  Debug.Log(Character.Strength);
        //Debug.Log(Character.ExtraStats);
    }

    public void PointsOnVitality()
    {

        if (Character.ExtraStats <= 0)
            return;
        Character.Vitality += 1;
        Character.ExtraStats -= 1;
        if (Character.ExtraStats <= 0)
        {
            Character.ExtraStats = 0;
        }
        EventManager.TriggerEvent("UpStat");


    }

    public void PointsOnAgility()
    {

        if (Character.ExtraStats <= 0)
            return;
        Character.Agility += 1;
        Character.ExtraStats -= 1;
        if (Character.ExtraStats <= 0)
        {
            Character.ExtraStats = 0;
        }
        EventManager.TriggerEvent("UpStat");

    }

    public void PointsOnIntellect()
    {

        if (Character.ExtraStats <= 0)
            return;
        Character.Intellect += 1;
        Character.ExtraStats -= 1;
        if (Character.ExtraStats <= 0)
        {
            Character.ExtraStats = 0;
        }
        EventManager.TriggerEvent("UpStat");

    }




    #endregion AddAttributeButton


}
