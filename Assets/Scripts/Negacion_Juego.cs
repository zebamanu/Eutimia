using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Negacion_Juego : MonoBehaviour
{
    [SerializeField]
    Texture2D mouseNO;

    string[] dialogoMotivacional = {"Deshonra", "Desgracia", "Vergüenza", "Catástrofe", "Desastre", "Drama", "Horror", "Caos", "Apocalipsis"};

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(mouseNO, new Vector2(mouseNO.width/2, mouseNO.height/2), CursorMode.ForceSoftware);
        PuntajeController.Instance.EmpezarDesafio(8, 40);
        StartCoroutine(Mensaje1());
    }

    IEnumerator Mensaje1()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"Juguemos a que me depositan y yo intento adivinar quién fue"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje2());
    }

    IEnumerator Mensaje2()
    {
        yield return new WaitForSeconds(5);
        string[] dialogo = {"Por cada taza de arroz son dos de agua"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
        StartCoroutine(Mensaje3());
    }

    IEnumerator Mensaje3()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"Si no te mantiene, no te detiene"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(5);
        DialogosController.Instance.CerrarDialogo();
    }

    private float tiempo = 0;
    private float tiempoTotal = 0;
    [SerializeField]
    private float periodo = 3;
    [SerializeField]
    private GameObject Palabra = null;
    void Update(){
        tiempo += Time.deltaTime;
        tiempoTotal += Time.deltaTime;
        if (tiempo >= periodo){
            float posX = Random.Range(-8f, 8f);
            float posY = Random.Range(-1.2f, 4f);
            string p = dialogoMotivacional[Random.Range(0, dialogoMotivacional.Length)];
            Vector3 position = new Vector3(posX, posY, 0);
            GameObject instancia = Instantiate(Palabra, position, Quaternion.identity);
            instancia.GetComponent<TMPro.TMP_Text>().text = p;
            tiempo = 0;
        }
        if (tiempoTotal > 20){
            periodo = 1;
        }
    }
}
