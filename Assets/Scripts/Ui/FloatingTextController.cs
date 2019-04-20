using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextController : MonoBehaviour
{
    private static FloatingText popUpText;
    private static GameObject canvas;
    private static List<GameObject> canvases;
    public static void Init()
    {
        /*  GameObject[] can = GameObject.FindGameObjectsWithTag("init");
          foreach (GameObject cans in can)
          {
              canvases.Add(cans);
          }
       */

        //find by tag
        canvas = GameObject.Find("InitCanvas");
        if (!popUpText)
        popUpText = Resources.Load<FloatingText>("PopUpUi/PopUpTextParent");
      

    }
    
    public static void CreateFloatingText(string text, Transform location)
    {
       
        //instatiate popuptext
        FloatingText instance = Instantiate(popUpText);
        
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(location.position);
        screenPosition.y += 25;
        Debug.Log(screenPosition.ToString());
        //set parent
        instance.transform.SetParent(canvas.transform,false);
      //  instance.transform.position = screenPosition;
        instance.SetText(text);
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
