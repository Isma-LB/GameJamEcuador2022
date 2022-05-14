using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyserScript : MonoBehaviour
{
    [SerializeField] AreaEffector2D geizer;
    [SerializeField] BotonGeiser boton1;
    [SerializeField] BotonGeiser boton2;
    [SerializeField] BotonGeiser boton3;

    // Start is called before the first frame update
    void Start()
    {
        geizer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (boton1.estado || boton2.estado || boton3.estado)
        {
            geizer.enabled = true;
        }
        else
        {
            geizer.enabled = false;
        }
    }
}
