using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MultiClick : MonoBehaviour , IPointerClickHandler ,IPointerEnterHandler,IPointerExitHandler
{
    Player owner;
    GameObject ItemPanel;
    Ray mouseRay;
    
    
public void OnPointerClick(PointerEventData eventData)
    {
       
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("right");
        }
       
    }  

    public void OnPointerEnter(PointerEventData eventData)
    {
        
        Debug.Log("hovering");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exited");
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
