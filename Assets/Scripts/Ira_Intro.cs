using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ira_Intro : MonoBehaviour
{
    void Start()
    {
        EventsController.Instance.StartEvent(15);
    }
}
