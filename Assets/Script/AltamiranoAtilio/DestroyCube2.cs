using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "SpawnCube3")
        {
            Destroy(gameObject);
        }
    }
}
