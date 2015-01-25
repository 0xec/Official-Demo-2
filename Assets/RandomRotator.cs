using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {
    public float Speed = 4.0f;
    void Start() {
        rigidbody.angularVelocity = Random.insideUnitSphere * Speed;
        rigidbody.velocity = new Vector3 (0, 0, -1) * Speed;
    }
}
