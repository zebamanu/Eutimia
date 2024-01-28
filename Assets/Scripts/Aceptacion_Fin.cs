using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aceptacion_Fin : MonoBehaviour
{
    void Start()
    {
        EventsController.Instance.StartEvent(78);
    }
}
