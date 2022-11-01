using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Variables
    [SerializeField] private float mouseSensitivity;
    private float limite = 0f;
    private Transform parent;
    // Start is called before the first frame update
    private void Start()
    {
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //parent.Rotate(new Vector3 (mouseX, mouseY, 0));
        limite -= mouseY;
        limite = Mathf.Clamp(limite, -90f, 90f);
        parent.Rotate(Vector3.up* mouseX);
        //parent.Rotate = Quaternion.Euler(limite, 0, 0);
        //parent.Rotate(Vector3.right, mouseY);
    }
}
