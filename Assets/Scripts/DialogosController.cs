using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogosController : MonoBehaviour
{


   //Signleton
    public static DialogosController Instance { get; private set;}
    [SerializeField]
    private TMPro.TMP_Text tDialogo;
    [SerializeField]
    private TMPro.TMP_Text tNombre;
    [SerializeField]
    private RawImage iPerfil;
    [SerializeField]
    private GameObject gameObject;

    private int idEvento;
    void Awake()
    {
         if (Instance != null && Instance != this){
            Destroy(this);
         }
         else
         {
            Instance = this;
         }
    }

    //Características del diálogo

    private string[] dialogo;
    private int indiceActual;
    public void SetDialogo(Character personaje, string[] dialogo, int idEvento){
      this.tNombre.text = personaje.Nombre;
      this.dialogo = dialogo;
      this.indiceActual = 0;
      this.iPerfil.texture = personaje.Perfil;
      this.idEvento = idEvento;
    }

    

    public void StartDialogo(){
      this.gameObject.SetActive(true);
      this.AvanzarDialogo();
    }

    public void AvanzarDialogo(){
      if (this.indiceActual < dialogo.Length){
        this.tDialogo.text = dialogo[indiceActual];
        if (tDialogo.text[0] == '*'){
          tDialogo.fontStyle = TMPro.FontStyles.Bold;
          tDialogo.text = tDialogo.text.Substring(1, tDialogo.text.Length - 1);
        }
        else if (tDialogo.text[0] == '#'){
          tDialogo.fontStyle = TMPro.FontStyles.Italic;
          tDialogo.text = tDialogo.text.Substring(1, tDialogo.text.Length - 1);
        }
        else
        {
          tDialogo.fontStyle = 0;
        }
        this.indiceActual++;
      }
      else
        this.CerrarDialogo();
    }
    public void CerrarDialogo(){
      this.gameObject.SetActive(false);
      if (this.idEvento != -1){
        EventsController.Instance.StartEvent(idEvento);
      }
    }
    
}
