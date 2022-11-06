using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float rotationSpeed = 80f;
    private float rotationX = 0f;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); //Limita la camara a 90 grados
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0); //Utilizado para representar la rotacion suave de la camara

        transform.parent.Rotate(Vector3.up*mouseX);
    }
}
