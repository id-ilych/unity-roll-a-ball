using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

  public float rotation = Random.Range(1f, 2f);
  
	void Update () {
    transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * rotation);
	}
}
