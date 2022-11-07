using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speedX = 4f;
    public float speedZ = 4f; 
    private float speedPlayer = 4f;
    //public float rotationSpeed= 64f;
    private Rigidbody PhysicJump; //Fisica de Salto
    public float jumpFoce = 7f; //Fuerza de salto
    private bool isJump; //Boleano que determina si el jugador esta en pleno salto
    private float numberJump = 0f;
    private float maxJump = 1f;
    public float numberPlayer;
    //private bool isPause = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Bloquea el cursor para que no salga de pantalla
        Cursor.visible = false; //Pone invisible al cursor del mouse
        PhysicJump = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Sprint();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speedPlayer * Time.deltaTime); //Permite mover al jugador

        /**if(isPause == true)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                isPause = false;
                SceneManager.LoadScene("MenuPausa");
                Cursor.lockState = CursorLockMode.None; //Habilita el movimiento del cursor
                Cursor.visible = true; //Pone visible el cursor
            }
        }*/
    }

    //Metodo que permite saltar al jugador
    void Jump()
    {
        if(numberJump > maxJump - 1f)
        {
            isJump = false;
        }
        if(isJump)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                PhysicJump.AddForce(new Vector3(0,jumpFoce,0), ForceMode.Impulse); //Añade fuerza de salto al jugador
                numberJump += 1;
            }
        }
    }
    
    void OnCollisionEnter(Collision other) 
    {
        isJump = true;
        numberJump = 0f;
    }
    void OnCollisionExit(Collision other) {
        
    }

    //Metodo que permite al jugador "correr" aplicando mas velocidad
    void Sprint()
    {
        if(Input.GetKey("left shift"))
        {
            speedPlayer = 10f;
        }else{
            speedPlayer = 4f;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemy01")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
            Cursor.lockState = CursorLockMode.None; //Habilita el movimiento del cursor
            Cursor.visible = true; //Pone visible el cursor
        }
    }
    
    /**Metodo que permite reiniciar el juego cuando el jugador se caiga al vacio.
    void ReiniciarJuego()
    {
        if(transform.position.y < -25f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }*/
}
