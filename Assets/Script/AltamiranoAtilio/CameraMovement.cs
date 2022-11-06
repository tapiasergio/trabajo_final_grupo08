using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float time = 0f;
    private bool isW;
    private bool isA;
    private bool isD;
    private bool isS;

    // Start is called before the first frame update
    void Start()
    {
        isW = true;
        isS = true;
        isA = true;
        isD = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w") && isW == true){ //al pulsar la w desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de time
    	Caminando();
    	isS = false;
        isD = false;
		isA = false;
    	}
        if(Input.GetKeyUp ("w")){ //al dejar de pulsar la tecla w, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
            Start();
            time = 0;
        
        }
        if(Input.GetKey("s")&& isS == true){ //al pulsar la s desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de time
            Caminando();
            isW = false;
            isD = false;
            isA = false;
        }
        if(Input.GetKeyUp ("s")){ //al dejar de pulsar la tecla s, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
            Start();
            time = 0;
            
        }
        if(Input.GetKey("a")&& isA == true){ //al pulsar la a desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de time
            Caminando();
            isS = false;
            isD = false;
            isW = false;
        }
        if(Input.GetKeyUp ("a")){ //al dejar de pulsar la tecla a, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
            Start();
            time = 0;
            
        }
        if(Input.GetKey("d")&& isD == true){ //al pulsar la d desactivar la llegada a "Caminar" desde las otras teclas para no hacer sumatorio de time
            Caminando();
            isS = false;
            isW = false;
            isA = false;
        }
        if(Input.GetKeyUp ("d")){ //al dejar de pulsar la tecla d, volver a la funcion Start(), para que todas las teclas esten disponibles para ser pulsadas
            time = 0;
            Start();
            
        }
    }

    void Caminando()
    {
        time += Time.deltaTime;
        if(time < 1)
        {
            GetComponent<Animation>().Play("PasoDerecho");
        }
        if(time > 1)
        {
            GetComponent<Animation>().Play("PasoIzquierdo");
        }
        if (time >= 2)
        {
            time = 0;
        }
    }
}
