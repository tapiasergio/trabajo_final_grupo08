using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    private Ray _ray;
    private RaycastHit _raycastHit;
   
        void Update()
        {
            float maxDistance = 20f;
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.green);

            if (Physics.Raycast(ray, out hit, maxDistance))
            {
               Debug.Log("Distance:" + hit.distance);
               hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            if(Physics.Raycast(_ray,out _raycastHit)) 
            {
                Destroy(_raycastHit.transform.gameObject);
            }
            
            }
            
        }
    
}

