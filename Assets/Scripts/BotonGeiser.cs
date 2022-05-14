using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonGeiser : MonoBehaviour
{
    [SerializeField] GameObject graficos;
    Animator animatorGeiser;

    public bool estado;

    // Start is called before the first frame update
    void Start()
    {
        animatorGeiser = graficos.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        animatorGeiser.Play("inicio");
        Debug.Log("Geiser encendido");
        estado = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Geiser apagado");
        estado = false;
        animatorGeiser.Play("parar");
    }
}
