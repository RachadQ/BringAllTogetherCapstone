using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem instance { get; set; }
    //chatSystem
    public List<MessageSystem> messageList = new List<MessageSystem>();
    int maxMessage = 10;
    public GameObject messagePref;
    public GameObject contentHolder;
    public TMP_InputField chatBox;
    //annoucement
    public string announcement;
    Text announcementText;
    //Npc Dialogue
    public string npcName;
    public List<string> NpcDialogue = new List<string>();
    
    public GameObject dialoguePanel;
    Button nextButton;
    Text dialogueText, npcNameText;
    int dialogueIndex;

    float systemTimer = 5;
    void Start()
    {
        //find inputfield
        chatBox = GameObject.FindGameObjectWithTag("chatbox").GetComponent<TMP_InputField>() as TMP_InputField;
        //find chat panel
        contentHolder = GameObject.FindGameObjectWithTag("Content");
        //Get dialogue panel child...Next button
        nextButton = dialoguePanel.transform.Find("NextButton").GetComponent<Button>();
        //grab the dialogue text
        dialogueText = dialoguePanel.transform.Find("TextPanel/dialogueText").GetComponent<Text>();
        //grab Npc Name
        npcNameText = dialoguePanel.transform.Find("NamePanel/NpcName").GetComponent<Text>();
        //listen to player click next button
        //get annoucement Text
        announcementText = GameObject.FindGameObjectWithTag("systemDialogue").GetComponent<Text>();
        //deactivate system message
        announcementText.enabled = false;
        nextButton.onClick.AddListener(delegate { CountinueDialogue(); });
        //turn off dialogue
        dialoguePanel.SetActive(false);
        //if instance exist is it null...if it does exist is it equal to dialogue system
        if (instance != null && instance != this)
        {
            // instance is exist that not this istance
            Destroy(gameObject);
        }
        else
        {
            //instance doesn't exist
            instance = this;
        }
    }

    public void SendAnnouncement(string dialogue)
    {
        StartCoroutine(ShowMessage(dialogue, systemTimer));
    }

    public void SendMessageToChat(string _message)
    {
        if (messageList.Count >= maxMessage)
        {
            //Delete first message sent
            Destroy(messageList[0].message.gameObject);
            //tempt dont remove continue to add database
            messageList.Remove(messageList[0]);
        }
        //assign message sent to a tempt message
        MessageSystem newMessage = new MessageSystem();
        newMessage.text = _message;

        GameObject newText = Instantiate(messagePref, contentHolder.transform);
        newMessage.message = newText.GetComponent<TextMeshProUGUI>();
        newMessage.message.text = newMessage.text;
        messageList.Add(newMessage);
    }
    IEnumerator ShowMessage(string message, float delay)
    {
        announcementText.text = message;
        announcementText.enabled = true;
        yield return new WaitForSeconds(delay);
        announcementText.enabled = false;
    }
    public void AddNewDialogue(string[] dialogue, string npcName)
    {
        //set dialogue index to 0
        dialogueIndex = 0;
        //create a new empty dialogue
        NpcDialogue = new List<string>(dialogue.Length);
        NpcDialogue.AddRange(dialogue);

        this.npcName = npcName;
        Debug.Log(NpcDialogue.Count);
        StartDialogue();
    }

    public void StartDialogue()
    {

        //show first dialogue
        dialogueText.text = NpcDialogue[dialogueIndex];
        //set NPC name
        npcNameText.text = npcName;
        //pop up dialogue Panel
        dialoguePanel.SetActive(true);
    }

    public void AddOption(string value, byte _lineback)
    {

    }
    public void CountinueDialogue()
    {

        // check if dialogue index is less then number of dialogue -1 amount of index 
        if (dialogueIndex < NpcDialogue.Count - 1)
        {

            dialogueIndex++;
            //set dialogue text to new dialogue index
            dialogueText.text = NpcDialogue[dialogueIndex];
        }
        else
        {

            // if it is last one close dailoguePanel
            dialoguePanel.SetActive(false);
        }

    }
    private void Update()
    {
       
    }
}
