using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventoryCash : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI diamondText;

    public InventoryCash(Player owner)
    {
        goldText = GameObject.FindGameObjectWithTag("GoldText").GetComponent<TextMeshProUGUI>();
        diamondText = GameObject.FindGameObjectWithTag("DiamondText").GetComponent<TextMeshProUGUI>();

    }

  
  
}
