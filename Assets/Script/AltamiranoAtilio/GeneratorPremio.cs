using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPremio : MonoBehaviour
{
    public GameObject CubeRed;
    public GameObject positionCube;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Cubo1") //Si colisiona con el objeto de tag "Object" aplicara el metodo GeneratePremio
        {
            GenerateCubeRed();
        }
    }

    //Metodo que instancia el objeto Premio
    void GenerateCubeRed()
    {
        Instantiate(CubeRed, positionCube.transform.position, CubeRed.transform.rotation);
    }
}
