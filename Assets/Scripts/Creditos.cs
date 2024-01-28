using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject boton;
    void Start()
    {
        StartCoroutine(MostrarBoton());
    }

    IEnumerator MostrarBoton(){
        yield return new WaitForSeconds(18);
        boton.SetActive(true);
    }

    public void VolverAlMenu(){
        SceneManager.LoadScene("Menu");
    }
}
