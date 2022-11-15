using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene("WinScene");
            Cursor.lockState = CursorLockMode.None; //Habilita el movimiento del cursor
            Cursor.visible = true; //Pone visible el cursor
        }
    }
}
