using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController 
{
    public Camera cam;
    public Transform target;
    // Start is called before the first frame update
    public CameraController(Transform player)
    {
        cam = Camera.main;
        target = player;
    }
    void Start()
    {
       // cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CameraMovement()
    {
        //Vector3 thirdPersonView = this.transform.position + playerCamera.Offset;
        // Vector3 TPVS = Vector3.Lerp(this.transform.position, thirdPersonView, PlayerCamera.smoothing *Time.deltaTime);
        // cam.transform.position = TPVS;
       
        

        cam.transform.position =  target.transform.position- target.forward* 20 + target.up * 15;
        cam.transform.LookAt(target);
        cam.transform.parent = target;
    }
 
}
