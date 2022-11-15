using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh_controller : MonoBehaviour
{
    public Transform objetivo; //esta variable se utilza para asignar el gameObject que va a seguir el enemigo
    private NavMeshAgent agent;//se utiliza generar el recorrido de las areas transitables y los obstaculos en su entorno para encontrar rutas y navegar controladas por la IA
    public float SpeedEnemy;//velocidad del enemigo

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();//inicializamos el componente
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = objetivo.position;//a la posicion del enemigo se le asigna la posicion del player
        transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, SpeedEnemy * Time.deltaTime);//velocidad de movimiento del enemigo

    }
}
