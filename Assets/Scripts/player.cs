using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private float speed = 20f;
    private float gravity = 9.8f;
    
    void Start()
    {
        //provide movement to the player
        //access the character controller obj
        //assign thr object movements
        controller = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState=CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction =new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * speed;
        velocity.y -= gravity;
        velocity = transform.transform.TransformDirection(velocity);
        controller.Move(velocity*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState=CursorLockMode.None;
        }
        

    }
}
