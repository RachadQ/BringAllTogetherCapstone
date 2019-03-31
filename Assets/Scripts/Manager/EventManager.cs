using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    private Dictionary<string, UnityEvent> eventDictionary;
    private static EventManager eventManager;

    public static EventManager instance
    {
        get
        {
            //if no don't have instance of eventManager
            if (!eventManager )
            {
                eventManager = FindObjectOfType(typeof(EventManager)) as EventManager;
                if (!eventManager)
                {
                    Debug.LogError("THen need to be one active Eventmanager script on a game object oin your scene");
                }
                else
                {
                    //initalize event manage
                    eventManager.Init();
                }
            }
            return eventManager;
        }
    }

    void Init()
    {
        if (eventDictionary == null)
        {
            // set event dictionary
            eventDictionary = new Dictionary<string, UnityEvent>();
        }
    }


    public static void StartListening(string eventName,UnityAction listener)
    {
        //create new unity event
        UnityEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.AddListener(listener);
        }
        //handle if dictinoary is empty
        else
        {
            thisEvent = new UnityEvent();
            //take this event that just created and add listener to it
            thisEvent.AddListener(listener);
            // then add  to the dictionary
            instance.eventDictionary.Add(eventName, thisEvent);
        }
    }

    public static void StopListening(string eventName, UnityAction listener)
    {
        //if dont find event manager
        if (eventManager == null) return;
        {
            // and remove entry if it exist
            UnityEvent thisEvent = null;
            //try get event by name and sennd to the dictionary the event we just created
            if (instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }
    }

    public static void TriggerEvent(string eventName)
    {
        UnityEvent thisEvent = null;
        
        if (instance.eventDictionary.TryGetValue(eventName,out thisEvent))
        {
            //call all functions that on listeners that all listening to veents
            thisEvent.Invoke();
        }
    }
}
