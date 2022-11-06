using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUpObject : MonoBehaviour
{
    public GameObject LookObject;
    public GameObject CaughtObject;
    public GameObject GrabZone;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        //Metodo que permite simular el agarre de objeto con tecla E, usando tambien otro c# de nombre "GetObject"
        if(LookObject != null && LookObject.GetComponent<GetObject>().isGetObject == true && CaughtObject == null)
        {
            if(Input.GetKeyDown(KeyCode.E)) //Si se presiona la tecla E, el objeto sera trasladado a la posicion de agarre ubicada en el jugador
            {
                CaughtObject = LookObject;
                CaughtObject.GetComponent<GetObject>().isGetObject = false;
                CaughtObject.transform.SetParent(GrabZone.gameObject.transform);
                CaughtObject.transform.position = GrabZone.transform.position;
                CaughtObject.GetComponent<Rigidbody>().useGravity = false;
                CaughtObject.GetComponent<Rigidbody>().isKinematic = true;
            }
        }else if(CaughtObject != null)
        {
            if(Input.GetKeyDown(KeyCode.E)) //Si se suelta el objeto, sera posible agarrar otro objeto
            {
                CaughtObject.GetComponent<GetObject>().isGetObject = true;
                CaughtObject.transform.SetParent(null);
                CaughtObject.GetComponent<Rigidbody>().useGravity = true;
                CaughtObject.GetComponent<Rigidbody>().isKinematic = false;
                CaughtObject = null;
            }
        }
    }
}
