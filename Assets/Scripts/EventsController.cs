using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventsController : MonoBehaviour
{
    public static EventsController Instance { get; private set;}
    [SerializeField]
    private Texture perfilBeleth = null;
    [SerializeField]
    private Texture perfilProta = null;
    [SerializeField]
    private Texture perfilTarot = null;

    [SerializeField]
    private Texture perfilNegociacion = null;
        
    [SerializeField]
    private Texture perfilMonstruo = null;
    public Character Beleth;
    public Character Protagonista;
    public Character Tarot;

    public Character Negociacion;

    public Character Monstruo;

    void Awake()
    {
         if (Instance != null && Instance != this){
            Destroy(this);
         }
         else
         {
            Instance = this;
            Beleth = new Character("Beleth", perfilBeleth);
            Protagonista = new Character("Protagonista", perfilProta);
            Tarot = new Character("Kiki", perfilTarot);
            Negociacion = new Character("Beleth", perfilNegociacion);
            Monstruo = new Character("????", perfilMonstruo);
         }
    }

    public void StartEvent(int idEvent){
       Invoke("Evento" + idEvent, 0);
    }

    void Evento0(){
      string[] dialogo = {"Es-el-mejor-día-de-mi-vida-es-el-mejor-día-de-mi-vida-es-el-mejor-día-de-mi-vida-es-el-mejor-día-de-mi-vida-es-el-mejor-día-de-mi-vida-es-el-mejor-día-de-mi-vida-es-el-mejor-día-de-mi-vida-es-el-mej"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 1);
      DialogosController.Instance.StartDialogo();
    }

    void Evento1(){
      string[] dialogo = {"ParÁÁaaaaaaa, ¿qué te pasa?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 2);
      DialogosController.Instance.StartDialogo();
    }

    void Evento2(){
      string[] dialogo = {"Nada, es el mejor día de mi vida.", "ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VID"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 3);
      DialogosController.Instance.StartDialogo();
    }
    void Evento3(){
      string[] dialogo = {"Una más de esas y vas a sentir la furia de mi patita."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 4);
      DialogosController.Instance.StartDialogo();
    }
    void Evento4(){
      string[] dialogo = {"ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VID"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 5);
      DialogosController.Instance.StartDialogo();
    }
    void Evento5(){
      string[] dialogo = {"¿De verdad esa es tu reacción a lo que acaba de pasar?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 6);
      DialogosController.Instance.StartDialogo();
    }
    void Evento6(){
      string[] dialogo = {"¡No pasó nada dije!", "*ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VIDA-ES-EL-MEJOR-DÍA-DE-MI-VID"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 7);
      DialogosController.Instance.StartDialogo();
    }
   void Evento7(){
      SceneManager.LoadScene("Negacion_Juego");
    }

    void Evento8(){
      SceneManager.LoadScene("Negacion_Fin");
    }

    void Evento9(){
      string[] dialogo = {"¡¡¡QUE NO DIJE!!!"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 10);
      DialogosController.Instance.StartDialogo();
    }

    void Evento10(){
      string[] dialogo = {"Calmaaate, no fue para tanto."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 11);
      DialogosController.Instance.StartDialogo();
    }

    void Evento11(){
      string[] dialogo = {"¿CÓMO QUE NO? ¿¡CÓMO QUE NO!? ¡¡¡ES UN MONTÓN!!!!"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 12);
      DialogosController.Instance.StartDialogo();
    }

    void Evento12(){
      string[] dialogo = {"No exageres, no es el fin del mundo."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 13);
      DialogosController.Instance.StartDialogo();
    }

    void Evento13(){
      string[] dialogo = {"SÍ LO ES, ES UNA CATÁSTROFE, UNA DESGRACIA, UNA BLASFEMIA", "*¡¡¡¡¡¡ES EL FIN DEL MUNDO!!!!!!"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 14);
      DialogosController.Instance.StartDialogo();
    }

    void Evento14(){
      SceneManager.LoadScene("Ira_Intro");
    }

    void Evento15(){
      string[] dialogo = {"*¡¡¡¡¡¡AAAAAAAAAAAARGH!!!!!!"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 16);
      DialogosController.Instance.StartDialogo();
    }

    void Evento16(){
      string[] dialogo = {"Bajale dos rayitas, de verdad tenés serios problemas de ira."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 17);
      DialogosController.Instance.StartDialogo();
    }

    void Evento17(){
      string[] dialogo = {"¡Es que no puede ser! ¿Cómo me pudo haber pasado eso?", "Una bronca loco, nunca tuve tanta bronca."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 18);
      DialogosController.Instance.StartDialogo();
    }

    void Evento18(){
      string[] dialogo = {"¿Y qué vas a hacer al respecto? ¿Pegarle a las baldosas?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 19);
      DialogosController.Instance.StartDialogo();
    }

    void Evento19(){
      string[] dialogo = {"SÍ."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 20);
      DialogosController.Instance.StartDialogo();
    }

    void Evento20(){
      SceneManager.LoadScene("Ira_Juego");
    }

    void Evento21(){
      SceneManager.LoadScene("Ira_Fin");
    }

    void Evento22(){
      string[] dialogo = {"¿Ya te desquitaste?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 23);
      DialogosController.Instance.StartDialogo();
    }

   void Evento23(){
      string[] dialogo = {"Sí, pero sigo indignada."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 24);
      DialogosController.Instance.StartDialogo();
    }
      
   void Evento24(){
      string[] dialogo = {"Y bueno, la baja bastante lo que pasó."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 25);
      DialogosController.Instance.StartDialogo();
    }

    void Evento25(){
      string[] dialogo = {"Te juro que sigo sin creerlo, no tiene ningún sentido.", "¿Por qué tuvo que pasar? ¿Por qué A MÍ?", "Estoy segura de que si hubiese estado más atenta, no me habría pasado."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 26);
      DialogosController.Instance.StartDialogo();
    }
   
   void Evento26(){
      string[] dialogo = {"Probablemente. Te pasa por distraída."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 27);
      DialogosController.Instance.StartDialogo();
    }

    void Evento27(){
      SceneManager.LoadScene("Negociacion_Intro");
    }

    void Evento28(){
      string[] dialogo = {"Hay que buscar alguna forma de que no me vuelva a pasar."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 29);
      DialogosController.Instance.StartDialogo();
    }

    void Evento29(){
      string[] dialogo = {"¿A qué te referís?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 30);
      DialogosController.Instance.StartDialogo();
    }

    void Evento30(){
      string[] dialogo = {"No sé, algo se tiene que poder hacer."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 31);
      DialogosController.Instance.StartDialogo();
    }

    void Evento31(){
      string[] dialogo = {"¿Algo que esté a tu alcance? Lo dudo."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 32);
      DialogosController.Instance.StartDialogo();
    }

    void Evento32(){
      string[] dialogo = {"¡ESO ES!"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 33);
      DialogosController.Instance.StartDialogo();
    }

    void Evento33(){
      string[] dialogo = {"¿Eso es khé?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 34);
      DialogosController.Instance.StartDialogo();
    }

    void Evento34(){
      string[] dialogo = {"Yo no puedo hacer nada, vos menos…", "Pero estoy segura de quién sí…"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 35);
      DialogosController.Instance.StartDialogo();
    }

    void Evento35(){
      //Hacer aparecer a la tarotista
      GameObject.FindWithTag("Kiki").GetComponent<SpriteRenderer>().enabled = true;
      string[] dialogo = {"Bienvenidos.", "Faber est suae quisque fortunae.", "#(El humano es artífice de su destino)"};
      DialogosController.Instance.SetDialogo(Tarot, dialogo, 36);
      DialogosController.Instance.StartDialogo();
    }
    void Evento36(){
      string[] dialogo = {"AY QUÉ SON ESTOS PUNTITOS QUE TENGO EN LA CARA?", "*¡¿AY QUÉ LE PASÓ A TU OJO?!"};
      DialogosController.Instance.SetDialogo(Negociacion, dialogo, 37);
      DialogosController.Instance.StartDialogo();
    }

    void Evento37(){
      string[] dialogo = {"¡Silencio Beleth! Esas cosas no se dicen."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 38);
      DialogosController.Instance.StartDialogo();
    }

    void Evento38(){
      string[] dialogo = {"¿A quién de los dos estás mirando?"};
      DialogosController.Instance.SetDialogo(Negociacion, dialogo, 39);
      DialogosController.Instance.StartDialogo();
    }

    void Evento39(){
      string[] dialogo = {"Bruja, necesito tu ayuda."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 40);
      DialogosController.Instance.StartDialogo();
    }

    void Evento40(){
      string[] dialogo = {"Díganme Kiki, por favor. Haré lo que me sea posible."};
      DialogosController.Instance.SetDialogo(Tarot, dialogo, 41);
      DialogosController.Instance.StartDialogo();
    }

    void Evento41(){
      string[] dialogo = {"Muchas gracias."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 42);
      DialogosController.Instance.StartDialogo();
    }

    void Evento42(){
      string[] dialogo = {"Empecemos."};
      DialogosController.Instance.SetDialogo(Tarot, dialogo, 43);
      DialogosController.Instance.StartDialogo();
    }

    void Evento43(){
      SceneManager.LoadScene("Negociacion_Juego");
    }

    void Evento44(){
      SceneManager.LoadScene("Negociacion_Fin");
    }

    void Evento45(){
      string[] dialogo = {"Mezcle bien, bruja pedorra."};
      DialogosController.Instance.SetDialogo(Negociacion, dialogo, 46);
      DialogosController.Instance.StartDialogo();
    }

    void Evento46(){
      string[] dialogo = {"¡Beleth! Te quedaste una semana sin atún."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 47);
      DialogosController.Instance.StartDialogo();
    }

    void Evento47(){
      string[] dialogo = {"Espero que las cartas hayan ayudado en tu proceso de negociación.", "Recordá que todavía tenés mucho camino por recorrer. Es importante que te mantengas fuerte."};
      DialogosController.Instance.SetDialogo(Tarot, dialogo, 48);
      DialogosController.Instance.StartDialogo();
    }

    void Evento48(){
      string[] dialogo = {"Voy a intentarlo. Gracias."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 49);
      DialogosController.Instance.StartDialogo();
    }

    void Evento49(){
      string[] dialogo = {"Kiki, me pierdo en tu mirada."};
      DialogosController.Instance.SetDialogo(Negociacion, dialogo, 50);
      DialogosController.Instance.StartDialogo();
    }

    void Evento50(){
      string[] dialogo = {"Gracias Beleth, aprecio el elogio."};
      DialogosController.Instance.SetDialogo(Tarot, dialogo, 51);
      DialogosController.Instance.StartDialogo();
    }

    void Evento51(){
      string[] dialogo = {"¿Elogio? Lo decía por lo bizca."};
      DialogosController.Instance.SetDialogo(Negociacion, dialogo, 52);
      DialogosController.Instance.StartDialogo();
    }

    void Evento52(){
      string[] dialogo = {"*¡BELETH!"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 53);
      DialogosController.Instance.StartDialogo();
    }

    void Evento53(){
      SceneManager.LoadScene("Depresion_Intro");
    }

    void Evento54(){
      string[] dialogo = {"Ay Beleth, no sé si tiene sentido esto…"};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 55);
      DialogosController.Instance.StartDialogo();
    }

    void Evento55(){
      string[] dialogo = {"¿Hablarle a un gato? Yyyy… no es muy normalito que digamos."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 56);
      DialogosController.Instance.StartDialogo();
    }

    void Evento56(){
      string[] dialogo = {"Creo que nunca lo voy a poder superar. Es demasiado para mí."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 57);
      DialogosController.Instance.StartDialogo();
    }

    void Evento57(){
      string[] dialogo = {"Es bromis, ¿No?"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 58);
      DialogosController.Instance.StartDialogo();
    }

    void Evento58(){
      string[] dialogo = {"No puedo más, me rindo."};
      DialogosController.Instance.SetDialogo(Protagonista, dialogo, 59);
      DialogosController.Instance.StartDialogo();
    }

    void Evento59(){
      string[] dialogo = {"No puede ser…"};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 60);
      DialogosController.Instance.StartDialogo();
    }

    void Evento60(){
      string[] dialogo = {"*UAAAARGH *Ruido de bicho feo*"};
      DialogosController.Instance.SetDialogo(Monstruo, dialogo, 61);
      DialogosController.Instance.StartDialogo();
    }

    void Evento61(){
      string[] dialogo = {"Yo me encargo de esto."};
      DialogosController.Instance.SetDialogo(Beleth, dialogo, 62);
      DialogosController.Instance.StartDialogo();
    }

    void Evento62(){
      SceneManager.LoadScene("Depresion_Juego");
    }

    void Evento63(){
      SceneManager.LoadScene("Depresion_Fin");
    }
}
