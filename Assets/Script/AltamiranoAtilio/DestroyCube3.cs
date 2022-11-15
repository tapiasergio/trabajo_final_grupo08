using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube3 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "OpenDoor")
        {
            Destroy(gameObject);
        }
    }
}
