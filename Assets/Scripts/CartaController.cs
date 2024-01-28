using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaController : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private SpriteRenderer frente;

     Vector2 cursorOffset;

    void Start(){
        cursorOffset = new Vector2(mouseClick.width, 0);
        animator = gameObject.GetComponent<Animator>();
        StartCoroutine(AutoDestroy());
    }

    private bool tocado = false;
    IEnumerator AutoDestroy(){
        yield return new WaitForSeconds(10);
        if (!tocado) {PuntajeController.Instance.AgregarSegundos(3);
        Destroy(gameObject);}
    }

    public void SetDorso(Sprite sprite){
        this.frente.sprite = sprite;
    }

    [SerializeField] AudioClip[] audios;
    public void OnMouseDown(){
        tocado = true;
        AudioController.Instance.ReproducirClip(audios[Random.Range(0, audios.Length)]);
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
