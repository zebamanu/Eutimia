using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraController : MonoBehaviour
{
    private Animator animator;
    private TMPro.TMP_Text texto;

    [SerializeField]
    private Texture2D mouseOver;
    [SerializeField]
    private Texture2D mouseClick;

    Vector2 cursorOffset;

    void Start(){
        cursorOffset = new Vector2(mouseClick.width/2, mouseClick.height/2);
        animator = gameObject.GetComponent<Animator>();
        texto = gameObject.GetComponent<TMPro.TMP_Text>();
    }

    public void SetTexto(string texto){
        this.texto.text = texto;
    }

    void OnMouseEnter(){
        Cursor.SetCursor(mouseOver, cursorOffset, CursorMode.ForceSoftware);
    }

    [SerializeField] AudioClip audio;
    public void OnMouseDown(){
        AudioController.Instance.ReproducirClip(audio);
        Cursor.SetCursor(mouseClick, cursorOffset, CursorMode.ForceSoftware);
        animator.SetTrigger("destroy");
        Destroy(gameObject, 1);
    }
}
