using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{
     public string Nombre;
     public Texture Perfil;

     public Character(string nombre, Texture texture){
        this.Nombre = nombre;
        this.Perfil = texture;
     }
}