using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void BotonStart(){
        SceneManager.LoadScene("Negacion_Intro");
    }

    public void BotonSalir(){
        Application.Quit();
    }
}
