using UnityEngine;

[RequireComponent(typeof(CharacterController2D))]
public class CharacterMovement : MonoBehaviour {
  [SerializeField] CharacterController2D controller = null;
  public  InputTarget input = null;
  [SerializeField] float speed = 40;
  bool isDead = false;
  private void FixedUpdate() {
    if(input == null) return;
    controller.Move(input.horizontalAxis * speed *Time.fixedDeltaTime,false, input.jump);
    input.jump = false;
  }
  private void Update() {
    if(transform.position.y < -10 && !isDead){
      isDead = true;
      FindObjectOfType<GameManager>().GameOver();
    }
  }
}