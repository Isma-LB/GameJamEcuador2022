using System;
using UnityEngine;

public class InputManager : MonoBehaviour {
  [SerializeField] InputHandler[] inputTargets = null;
  InputTarget currentTarget;
  bool upArrow = false;
  bool downArrow = false;

  private void Start() {
    currentTarget = inputTargets[0].target;
  }

  private void Update() {

    checkTargets();

    currentTarget.horizontalAxis = Input.GetAxisRaw("Horizontal");

    float verticalAxis = Input.GetAxisRaw("Vertical");
    if(verticalAxis > 0.5 && !upArrow){
      currentTarget.jump = true;
      upArrow = true;
      AudioManager.Play(AudioEffects.jump);
    }
    else if(verticalAxis < 0.5){
      upArrow = false;
    }
    if(verticalAxis < -0.5 && !downArrow){
      currentTarget.crouch = true;
      downArrow = true;
    }
    else if(verticalAxis < 0.5){
      downArrow = false;
    }
  }

  private void checkTargets()
  {
    for (int i = 0; i < inputTargets.Length; i++)
    {
      if(Input.GetKeyDown(inputTargets[i].keycode)){
        currentTarget.Diselect();
        currentTarget = inputTargets[i].target;
        currentTarget.Selected();
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
