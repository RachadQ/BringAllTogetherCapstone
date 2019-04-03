using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    PlayerMovement movement;
    CameraController cam;
    // Start is called before the first frame update
    void Start()
    {
       
        movement = new PlayerMovement(this.gameObject);
        cam = new CameraController(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        cam.CameraMovement();
        movement.MovePlayer();
    }
}
