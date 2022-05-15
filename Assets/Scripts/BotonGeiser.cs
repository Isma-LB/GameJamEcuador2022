using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonGeiser : MonoBehaviour
{
    [SerializeField] GameObject graficos;

    public bool estado;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        estado = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        estado = false;
    }
}
