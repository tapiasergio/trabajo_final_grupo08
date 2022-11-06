using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private float speedRotation;
    private float jumpForce;
    private Rigidbody physicsBody;
   

    // Start is called before the first frame update
     private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        speed = 3f;
        speedRotation = 85f;
        jumpForce = 5f;
        physicsBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float posX=Input.GetAxis("Horizontal");
        float posZ=Input.GetAxis("Vertical");
        float rotationY = Input.GetAxis("Mouse X");

        transform.Translate(new Vector3(posX, 0f, posZ)*speed*Time.deltaTime);
        transform.Rotate(new Vector3(0f, rotationY, 0f)*speedRotation*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            physicsBody.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
       
    }
    
}
