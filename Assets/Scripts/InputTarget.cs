using UnityEngine;

[CreateAssetMenu(fileName = "InputTarget", menuName = "GameJamEcuador2022/InputTarget")]
public class InputTarget : ScriptableObject {
  public float horizontalAxis = 0;
  public bool jump = false;
  public bool crouch = false;
  public delegate void Select();
  public Select onSelect;
  public Select onDiselect;

  public void Selected(){
    if(onSelect != null){
      onSelect.Invoke();
    }
  }
  public void Diselect(){
    horizontalAxis = 0;
    jump = false;
    crouch = false;
    if(onDiselect != null){
      onDiselect.Invoke();
    }
  }
}