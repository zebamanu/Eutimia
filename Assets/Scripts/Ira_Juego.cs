using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ira_Juego : MonoBehaviour
{
    [SerializeField]
    Texture2D mouseMano;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 cursorOffset = new Vector2(mouseMano.width/2, mouseMano.height/2);
        Cursor.SetCursor(mouseMano, cursorOffset, CursorMode.ForceSoftware);
        PuntajeController.Instance.EmpezarDesafio(21, 40);
        StartCoroutine(Mensaje1());
    }

    IEnumerator Mensaje1()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"No me hablen, solo si tienen chisme o plata."};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje2());
    }

    IEnumerator Mensaje2()
    {
        yield return new WaitForSeconds(5);
        string[] dialogo = {"¿Estás solo? Cariñosita a menos de 3km de ti."};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje3());
    }

    IEnumerator Mensaje3()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"No acepto cumplidos, solo transferencias."};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
    }

    private float tiempo = 0;
    private float speed = 4f;
    private float tiempoTotal = 0;
    [SerializeField]
    private float periodo = 3;
    [SerializeField]
    private GameObject[] Baldosas = null;
    void Update(){
        tiempo += Time.deltaTime;
        tiempoTotal += Time.deltaTime;
        if (tiempo >= periodo){
            float posX = Random.Range(-10f, 10f);
            float posY = Random.Range(-1.2f, 4f);
            GameObject Baldosa = Baldosas[Random.Range(0,Baldosas.Length)];
            Vector3 position = new Vector3(posX, posY, 0);
            GameObject instancia = Instantiate(Baldosa, position, Quaternion.identity);
            float velocidad = posX < 0 ? speed : -speed;
            instancia.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, 0);
            tiempo = 0;
        }
        if (tiempoTotal > 20){
            periodo = 1;
            speed = 8f;
        }
    }
}
