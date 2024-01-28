using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class SiguienteController : MonoBehaviour
{
    [SerializeField] RectTransform rect;
    // Start is called before the first frame update
    private float segundos = 0;
    private bool seMueve = true;
    Rect screenBounds = new Rect(0f, 0f, Screen.width, Screen.height);
    // Update is called once per frame
    void Update()
    {
        if (seMueve){
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rect,Input.mousePosition, null, out Vector2 mousePos);
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rect,transform.position, null, out Vector2 myPos);
            Vector2 distance = myPos + new Vector2(30, 30) - mousePos;
            Debug.Log(distance);
            Vector2 direction = distance.normalized;
            if (distance.magnitude < 100){
                Vector2 delta = direction * (100 - distance.magnitude);
                transform.position = transform.position + new Vector3(delta.x, delta.y, 0);
                if (!screenBounds.Contains(transform.position)){
                    transform.position = new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height), 0);
                }
            }
            segundos += Time.deltaTime;
            if (segundos >=45){
                seMueve = false;
                
            }
        }
    }
}
