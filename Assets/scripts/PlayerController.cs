using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
  public float speed;
  public Text scoreLabel;
  public Text winLabel;

  private Rigidbody rigitBody;
  private int score;

  void Start() {
    rigitBody = GetComponent<Rigidbody>();
    score = 0;
    validateScoreLabel();
    winLabel.text = "";
  }

  void FixedUpdate() {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    Vector3 movement = speed * new Vector3(moveHorizontal, 0, moveVertical);
    rigitBody.AddForce(movement);
  }

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.CompareTag("PickUp")) {
      other.gameObject.SetActive(false);
      ++score;
      validateScoreLabel();
      if (score >= 28) {
        winLabel.text = "You win!";
      }
    }
  }

  private void validateScoreLabel() {
    scoreLabel.text = "Score: " + score;
  }
}
