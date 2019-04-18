using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasGroupManager : MonoBehaviour
{
    public UiGroup[] uiGroup;
    public UiGroup[] statusChild;
    private float offSet = 1.0f;
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

    public void DisplayDescriptionPanel()
    {
        //if inventory is open
        if (uiGroup[0].isActive == true)
        {
            statusChild[2].canvas.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + offSet);
            Debug.Log(statusChild[2].canvas.transform.position);
            statusChild[2].Switch();
            statusChild[2].canvas.blocksRaycasts = true;
            
        }
        
            
      
        
      
    }


    public void DisplayInventoryPanel()
    {
        uiGroup[0].Switch();
        //if inventory closes close 
        if (uiGroup[0].isActive == false)
        {
            // and item decription is open close it 
            if (statusChild[2].isActive == true)
            {
                statusChild[2].Switch();
               
            }
           
         
        }
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
