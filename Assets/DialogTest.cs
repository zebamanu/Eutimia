using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture sprite;
    public Texture2D mouse;
    private string[] dialogo = {"Esto funca?", "It seems like it", "Cata chupa morros"};

    public void Start(){
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.Auto);
    }

    public void test(){
        DialogosController.Instance.SetDialogo(new Character("Matías", sprite), dialogo, -1);
        DialogosController.Instance.StartDialogo();
    }
}
