using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasGroupManager : MonoBehaviour
{
    public UiGroup[] uiGroup;
    public UiGroup[] statusChild;  
  
    // Start is called before the first frame update
    void Start()
    {
        foreach (UiGroup canvasGroup in uiGroup)
        {
            canvasGroup.isActive = true;
            canvasGroup.Switch();    
            
           
           // canvasGroup.Switch();
            // canvasGroup.isActive = false;

        }
        
    }

    public void InfoPanel()
    {
     
        if (uiGroup[3].canvas.alpha == 1)
        {
   
            statusChild[1].canvas.alpha = 0;
            statusChild[1].canvas.blocksRaycasts = false;
            statusChild[0].canvas.alpha = 1;
            statusChild[0].canvas.blocksRaycasts = true;


        }
    }

   

public void GearPanel()
    {
        if (uiGroup[3].isActive == true)
        {

            statusChild[0].canvas.alpha = 0;
            statusChild[0].canvas.blocksRaycasts = false;
            statusChild[1].canvas.alpha = 1;
            statusChild[0].canvas.blocksRaycasts = true;



        }
    }

    public void DisplayInventoryPanel()
    {
        uiGroup[0].Switch();
    }

    public void DisplayGuildPanel()
    {
        
     
    
        uiGroup[1].Switch();
    }

    public void DisplayChatPanel()
    {
        uiGroup[2].Switch();
    }

    public void DisplayStatusPanel()
    {
        uiGroup[3].Switch();
    }


    public void DisplayMenu()
    {
        uiGroup[4].Switch();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
           // group[3].alpha = 1;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayInventoryPanel();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            DisplayStatusPanel();
        }
    }
}
