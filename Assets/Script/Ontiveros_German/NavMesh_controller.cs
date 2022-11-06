using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh_controller : MonoBehaviour
{
    public Transform objetivo;
    private NavMeshAgent agent;
    public float SpeedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = objetivo.position;
        transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, SpeedEnemy * Time.deltaTime);

        //NAVEGACION MEDIANTE CLICK
        /*
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.destination = hit.point;
            }
        }*/
    }
}
