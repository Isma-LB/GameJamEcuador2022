using System;
using UnityEngine;

public class InputManager : MonoBehaviour {
  [SerializeField] InputHandler[] inputTargets = null;
  InputTarget currentTarget;

  private void Start() {
    currentTarget = inputTargets[0].target;
  }

  private void Update() {

    checkTargets();

    currentTarget.horizontalAxis = Input.GetAxisRaw("Horizontal");
    currentTarget.jump = Input.GetKeyDown(KeyCode.Space);
  }

  private void checkTargets()
  {
    for (int i = 0; i < inputTargets.Length; i++)
    {
      if(Input.GetKeyDown(inputTargets[i].keycode)){
        currentTarget = inputTargets[i].target;
        return;
      }
    }
  }

  [System.Serializable]
  struct InputHandler{
    public KeyCode keycode;
    public InputTarget target;
  }
}
