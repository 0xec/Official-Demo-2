using UnityEngine;
using System.Collections;

public class Bolt : MonoBehaviour {
	public float Speed = 5.0f;
	void Start() {
		rigidbody.velocity = transform.forward * Speed;
		
	}
}
