using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negociacion_Fin : MonoBehaviour
{
    void Start()
    {
        EventsController.Instance.StartEvent(45);
    }
}
