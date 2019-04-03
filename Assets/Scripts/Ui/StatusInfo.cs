using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatusInfo 
{
    public Player owner;
    public Text playerName;
    public Text level;
    public Text pkPoints;
    public Text Spouse;
    public Text guildname;

    //Attribute
    public Text strength;
    public Text vitality;
    public Text agilty;
    public Text intellect;
    public Text extraStats;






    public StatusInfo(Player _owner)
    {

        owner = _owner;
        playerName = GameObject.Find("EntityName").GetComponent<Text>();
        level = GameObject.Find("EntityLevel").GetComponent<Text>();
        pkPoints = GameObject.Find("EntityPkPoints").GetComponent<Text>();
        Spouse = GameObject.Find("EntitySpouse").GetComponent<Text>();
        guildname = GameObject.Find("EntityGuild").GetComponent<Text>();

        strength = GameObject.Find("StrengthStat").GetComponent<Text>();
        vitality = GameObject.Find("VitalityStat").GetComponent<Text>();
        agilty = GameObject.Find("AgilityStat").GetComponent<Text>();
        intellect = GameObject.Find("IntellectStat").GetComponent<Text>();
        extraStats = GameObject.Find("ExtraStat").GetComponent<Text>();
        playerName.text = owner.EntityName;
        level.text = owner.Character.Level.ToString();
        pkPoints.text = owner.Character.Pk.ToString();
        //attributes
        strength.text = owner.Character.Strength.ToString();
        vitality.text = owner.Character.Vitality.ToString();
        agilty.text = owner.Character.Agility.ToString();
        intellect.text = owner.Character.Intellect.ToString();
        extraStats.text = owner.Character.ExtraStats.ToString();
       

        if (owner.Character.Spouse == null)
        {
            Spouse.text = "none";
        }
        else
        Spouse.text = owner.Character.Spouse;
        if (owner.guild.Name == null)
        {
            guildname.text = "none";
        }
        else
        guildname.text = owner.guild.Name;
    }

    public void UpdateLevel()
    {
        level.text = owner.Character.Level.ToString();
    }
    public void UpdateStrText()
    {
        strength.text = owner.Character.Strength.ToString();


    }
    public void UpdateAgiText()
    {
        agilty.text = owner.Character.Agility.ToString();
    }
    public void UpdateVitText()
    {
        vitality.text = owner.Character.Vitality.ToString();
    }
    public void UpdateIntText()
    {
        intellect.text = owner.Character.Intellect.ToString();
    }
    public void UpdateExtrText()
    {
        extraStats.text = owner.Character.ExtraStats.ToString();
    }

    public void updateStats()
    {
        UpdateAgiText();
        UpdateExtrText();
        UpdateIntText();
        UpdateStrText();
        UpdateVitText();

           
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
