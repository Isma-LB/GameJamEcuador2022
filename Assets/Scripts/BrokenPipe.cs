using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Collider2D))]
public class BrokenPipe : MonoBehaviour {
  [SerializeField] string playerTag = "Player";
  [SerializeField] ParticleSystem particleEffect = null;
  [SerializeField, Range(0.1f,1f)] float extraDelay = 0.5f;
  bool _fixed = false;
  public bool isFixed { get => _fixed;}

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == playerTag){
      particleEffect.Play();
      StartCoroutine(fixedIn(particleEffect.main.duration + extraDelay));
    }
  }
  IEnumerator fixedIn(float delay){
    yield return new WaitForSeconds(delay);
    _fixed = true;  
  }
}