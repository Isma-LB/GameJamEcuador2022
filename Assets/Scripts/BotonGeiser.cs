using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonGeiser : MonoBehaviour
{
    [SerializeField] GameObject graficos;

    public bool estado;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        estado = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        estado = false;
    }
}
