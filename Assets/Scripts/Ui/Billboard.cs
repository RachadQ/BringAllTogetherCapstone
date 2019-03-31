using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera m_Camera;
    public GameObject holder;
    private void LateUpdate()
    {
        
            transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward, m_Camera.transform.rotation * Vector3.up);
       
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
        m_Camera = Camera.main;
        
    }

    private void Awake()
    {
       
        
       // holder = billboard.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
