using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Collider2D))]
public class BrokenPipe : MonoBehaviour {
  [SerializeField] string playerTag = "Player";
  [SerializeField] ParticleSystem repairEffect = null;
  [SerializeField] ParticleSystem waterEffect = null;
  [SerializeField] AudioSource soundEffect = null;
  [SerializeField, Range(0.1f,1f)] float extraDelay = 0.5f;
  bool _fixed = false;
  public bool isFixed { get => _fixed;}

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == playerTag){
      soundEffect.Stop();
      waterEffect.Stop();
      repairEffect.Play();
      StartCoroutine(fixedIn(repairEffect.main.duration + extraDelay));
    }
  }
  IEnumerator fixedIn(float delay){
    yield return new WaitForSeconds(delay);
    _fixed = true;  
  }
}