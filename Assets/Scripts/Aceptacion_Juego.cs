using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aceptacion_Juego : MonoBehaviour
{
    [SerializeField]
    Texture2D mouseProta;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector2 cursorOffset = new Vector2(mouseProta.width, 0);
        Cursor.SetCursor(mouseProta, cursorOffset, CursorMode.ForceSoftware);
        PuntajeController.Instance.EmpezarDesafio(-1, 45);
        string[] dialogo = {"¿Aceptas todo lo que te pasó?"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        StartCoroutine(Mensaje1());
    }

    IEnumerator Mensaje1()
    {
        yield return new WaitForSeconds(10);
        string[] dialogo = {"¿Otra vez con las vueltas? Es decir que lo aceptás y punto…"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(10);
        StartCoroutine(Mensaje2());
    }
    IEnumerator Mensaje2()
    {
        string[] dialogo = {"Bueeeeeenoo…"};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(10);
        StartCoroutine(Mensaje3());
    }

    IEnumerator Mensaje3()
    {
        string[] dialogo = {"Yo digo que podría dormirme una siesta antes de que te decidas."};
        DialogosController.Instance.SetDialogo(EventsController.Instance.Beleth, dialogo, -1);
        DialogosController.Instance.StartDialogo();
        yield return new WaitForSeconds(15);
    }

    public void SiguienteNivel(){
        EventsController.Instance.StartEvent(77);
    }

}
