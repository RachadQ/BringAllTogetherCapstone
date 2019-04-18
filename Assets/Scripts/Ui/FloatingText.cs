using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FloatingText : MonoBehaviour
{
    public Animator animator;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    
    void OnEnable()
    {
        AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo(0);
        //destory after the length of the first clip
        //get first clip length
      //  Debug.Log(clipInfos[0].clip.length);
        Destroy(gameObject, clipInfos[0].clip.length +10);
        //get the component from the object animator is attached to
        text = animator.GetComponent<TextMeshProUGUI>();
    }

    public void  SetText(string _text)
    {
        text.text = _text;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
