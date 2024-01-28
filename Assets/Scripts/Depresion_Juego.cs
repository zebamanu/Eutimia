using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depresion_Juego : MonoBehaviour
{
    [SerializeField]
    Texture2D mouseCola;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 cursorOffset = new Vector2(mouseCola.width, 0);
        Cursor.SetCursor(mouseCola, cursorOffset, CursorMode.ForceSoftware);
        PuntajeController.Instance.EmpezarDesafio(63, 60);
    }

    
    private float tiempo = 0;
    private float tiempoTotal = 0;
    [SerializeField]
    private float periodo = 3;
    [SerializeField]
    private GameObject[] Fantasmas = null;
    void Update(){
        tiempo += Time.deltaTime;
        tiempoTotal += Time.deltaTime;
        if (tiempo >= periodo){
            float posX = Random.Range(-5f, 16f);
            float posY = 10f;
            GameObject Carta = Fantasmas[Random.Range(0,Fantasmas.Length)];
            Vector3 position = new Vector3(posX, posY, 0);
            GameObject instancia = Instantiate(Carta, position, Quaternion.identity);
            tiempo = 0;
        }
        if (tiempoTotal > 20){
            periodo = 1;
        }
        if (tiempoTotal > 40){
            periodo = 0.75f;
        }
    }
}
