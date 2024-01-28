using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negociacion_Juego : MonoBehaviour
{
    [SerializeField]
    Texture2D mouseMano;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 cursorOffset = new Vector2(mouseMano.width, 0);
        Cursor.SetCursor(mouseMano, cursorOffset, CursorMode.ForceSoftware);
        PuntajeController.Instance.EmpezarDesafio(44, 60);
        StartCoroutine(Mensaje1());
    }

    IEnumerator Mensaje1()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"Mmmm… ya puedo oler la latita de atún que va a traer esa fortuna."};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Negociacion, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje2());
    }

    IEnumerator Mensaje2()
    {
        yield return new WaitForSeconds(5);
        string[] dialogo = {"Lo que más me gusta de tus ojos, es mi reflejo."};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Negociacion, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje3());
    }

    IEnumerator Mensaje3()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"No pudo salvar el cuatrimestre mirá que va a salvar una relación…"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Negociacion, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje4());
    }

    IEnumerator Mensaje4()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"Ahhh... Piscis... ¡Cómo Justin!"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Negociacion, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
    }

    private float tiempo = 0;
    private float tiempoTotal = 0;
    [SerializeField]
    private float periodo = 3;
    [SerializeField]
    private GameObject[] Cartas = null;
    void Update(){
        tiempo += Time.deltaTime;
        tiempoTotal += Time.deltaTime;
        if (tiempo >= periodo){
            float posX = Random.Range(-8f, 8f);
            float posY = Random.Range(-1.2f, 4f);
            GameObject Carta = Cartas[Random.Range(0,Cartas.Length)];
            Vector3 position = new Vector3(posX, posY, 0);
            GameObject instancia = Instantiate(Carta, position, Quaternion.identity);
            Destroy(instancia, 8f);
            tiempo = 0;
        }
        if (tiempoTotal > 20){
            periodo = 1;
        }
        if (tiempoTotal > 40){
            periodo = 0.5f;
        }
    }
}
