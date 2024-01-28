﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeController : MonoBehaviour
{
    public static PuntajeController Instance { get; private set;}
    [SerializeField]
    private Text tTiempo;

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

    private bool tiempoCorre = false;
    private float tiempoActual = 40;
    private int siguienteEvento = 0;

    void Update(){
        if (tiempoCorre){
            tiempoActual -= Time.deltaTime;
            tTiempo.text = ((int)tiempoActual).ToString();
            if (tiempoActual <= 0){
                //TerminaDesafio
                Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
                EventsController.Instance.StartEvent(siguienteEvento);
            }
        }
    }

    public void EmpezarDesafio(int siguiente, int tiempoMax){
        tiempoActual = tiempoMax;
        tiempoCorre = true;
        siguienteEvento = siguiente;
    }
}
