using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject : MonoBehaviour
{
    public bool isGetObject = true;
    public float numberPremio;

    private void OnTriggerEnter(Collider other) 
    {
        //Si el objeto se encuentra dentro de la zona de agarre muestra su posicion para agarrar
        if(other.tag == "ZonaAgarre")
        {
            other.GetComponentInParent<GetUpObject>().LookObject = this.gameObject;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        //Si el objeto sale del rango de la zona de agarra la posicion mostrada es null
        if(other.tag == "ZonaAgarre")
        {
            other.GetComponentInParent<GetUpObject>().LookObject = null;
        }  
    }
}
