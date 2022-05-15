using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaScript : MonoBehaviour
{
    [SerializeField, Range(0.1f, 3f)] float timeToBreak = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.position.y > transform.position.y)
        {
            StartCoroutine(DestruirPlataforma());
        }
    }

    IEnumerator DestruirPlataforma()
    {
        yield return new WaitForSeconds(timeToBreak);
        gameObject.SetActive(false);
    }
}
