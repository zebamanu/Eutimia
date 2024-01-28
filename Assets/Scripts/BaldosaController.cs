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
        StartCoroutine(AutoDestroy());
    }

    IEnumerator AutoDestroy(){
        yield return new WaitForSeconds(10);
        PuntajeController.Instance.AgregarSegundos(5);
        Destroy(gameObject);
    }

    [SerializeField] AudioClip[] audios;
    public void OnMouseDown(){
        AudioController.Instance.ReproducirClip(audios[Random.Range(0, audios.Length)]);
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
