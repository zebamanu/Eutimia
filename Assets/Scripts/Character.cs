using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{
     public string Nombre;
     public Texture Perfil;

     public AudioClip[] sonidos;

     public Character(string nombre, Texture texture, AudioClip[] sonidos){
        this.Nombre = nombre;
        this.Perfil = texture;
        this.sonidos = sonidos;
     }
}