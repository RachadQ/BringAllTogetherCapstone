using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class UiGroup 
{
    public CanvasGroup canvas;
    public bool isActive;
    // Start is called before the first frame update

    public bool Switch()
    {
        isActive = !isActive;
        if (isActive == true)
        {

            canvas.alpha = 1;
            canvas.blocksRaycasts = true;
        }
        else
        {

            canvas.alpha = 0;
            canvas.blocksRaycasts = false;
        }


        return isActive;
    }


}
 

