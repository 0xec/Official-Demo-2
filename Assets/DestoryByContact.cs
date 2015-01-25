using UnityEngine;
using System.Collections;

public class DestoryByContact : MonoBehaviour {
    public GameObject explosion;
	void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != "Boundary") {
            GameObject temp = Instantiate (explosion, transform.position, transform.rotation) as GameObject;
            DestroyObject (other.gameObject);
            DestroyObject (gameObject);
            DestroyObject(temp, 3.0f);
        }

    }
}
