using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasaEscena : MonoBehaviour
{
    [SerializeField] string proximoNivel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextLevel());
    }

    IEnumerator NextLevel(){
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(proximoNivel);
    }
}
