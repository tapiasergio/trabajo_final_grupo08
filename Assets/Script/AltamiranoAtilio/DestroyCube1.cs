using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "SpawnCube2")
        {
            Destroy(gameObject);
        }
    }
}
