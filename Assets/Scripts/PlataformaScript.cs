using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.position.y > transform.position.y)
        {
            StartCoroutine(DestruirPlataforma());
            animator.Play("Ruptura");
        }
    }

    IEnumerator DestruirPlataforma()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
}
