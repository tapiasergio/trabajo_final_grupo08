using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCuboAzul : MonoBehaviour
{
    public GameObject CubeBlue;
    public GameObject positionCube;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Cubo2") //Si colisiona con el objeto de tag "Object" aplicara el metodo GeneratePremio
        {
            GenerateCubeBlue();
        }
    }

    //Metodo que instancia el objeto Premio
    void GenerateCubeBlue()
    {
        Instantiate(CubeBlue, positionCube.transform.position, CubeBlue.transform.rotation);
    }
}
