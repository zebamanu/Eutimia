
using System.Collections;
using UnityEngine;

public class FantasmaController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    public int vidas = 2;

     Vector2 cursorOffset;


    void Start(){
        cursorOffset = new Vector2(mouseClick.width, 0);
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        rb.velocity = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position).normalized * 3;
    }

    private bool fueTocado = false;

    IEnumerator BackOff(){
        rb.velocity = -rb.velocity * 3;
        yield return new WaitForSeconds(0.5f);
        rb.velocity = -rb.velocity / 3;
        fueTocado = false;
    }

    [SerializeField] AudioClip[] audios;
    public void OnMouseDown(){
        if (!fueTocado){
            fueTocado = true;
            AudioController.Instance.ReproducirClip(audios[Random.Range(0, audios.Length)]);
            Cursor.SetCursor(mouseHit, cursorOffset, CursorMode.ForceSoftware);
            if (--vidas <= 0){
                animator.SetTrigger("Die");
                rb.velocity = Vector2.zero;
                Destroy(gameObject, 1f);
            }
            else{
                animator.SetTrigger("Touch");
                StartCoroutine(BackOff());
            }
        }
        
    }

    [SerializeField]
    Texture2D mouseClick;
    [SerializeField]
    Texture2D mouseHit;

    void OnMouseEnter(){
        Cursor.SetCursor(mouseClick, cursorOffset, CursorMode.ForceSoftware);
    }
}
