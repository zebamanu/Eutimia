using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaldosaController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    [SerializeField]
    private Sprite baldosaRota;

     Vector2 cursorOffset;

    void Start(){
        cursorOffset = new Vector2(mouseClick.width/2, mouseClick.height/2);
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    public void OnMouseDown(){
        AudioController.Instance.ReproducirAudio(0);
        Cursor.SetCursor(mouseHit, cursorOffset, CursorMode.ForceSoftware);
        rb.velocity = Vector2.zero;
        sr.sprite = baldosaRota;
        Destroy(gameObject, 0.5f);
    }

    [SerializeField]
    Texture2D mouseClick;
    [SerializeField]
    Texture2D mouseHit;

    void OnMouseEnter(){
        Cursor.SetCursor(mouseClick, cursorOffset, CursorMode.ForceSoftware);
    }
}
