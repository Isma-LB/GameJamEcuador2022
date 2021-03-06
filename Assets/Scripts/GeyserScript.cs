using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyserScript : MonoBehaviour
{
    [SerializeField] AreaEffector2D geizer;
    [SerializeField] AreaEffector2D geizer2;
    [SerializeField] BotonGeiser boton1;
    [SerializeField] BotonGeiser boton2;
    [SerializeField] BotonGeiser boton3;

    ParticleSystem geizerParticles;
    ParticleSystem geizer2Particles;

    // Start is called before the first frame update
    void Start()
    {
        geizer.enabled = false;
        geizer2.enabled = false;

        geizerParticles = geizer.GetComponent<ParticleSystem>();
        geizer2Particles = geizer2.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boton1.estado || boton2.estado || boton3.estado)
        {
            geizer.enabled = true;
            geizer2.enabled = true;
        }
        else
        {
            geizer.enabled = false;
            geizer2.enabled = false;
        }
    }
}
