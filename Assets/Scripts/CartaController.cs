using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaController : MonoBehaviour
{
    private Animator animator;

     Vector2 cursorOffset;

    void Start(){
        cursorOffset = new Vector2(mouseClick.width, 0);
        animator = gameObject.GetComponent<Animator>();
    }

    public void OnMouseDown(){
        AudioController.Instance.ReproducirAudio(0);
        Cursor.SetCursor(mouseHit, cursorOffset, CursorMode.ForceSoftware);
        animator.SetTrigger("Touch");
        Destroy(gameObject, 3f);
    }

    [SerializeField]
    Texture2D mouseClick;
    [SerializeField]
    Texture2D mouseHit;

    void OnMouseEnter(){
        Cursor.SetCursor(mouseClick, cursorOffset, CursorMode.ForceSoftware);
    }
}
