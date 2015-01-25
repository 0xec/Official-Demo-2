using UnityEngine;
using System.Collections;

public class DestoryBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other) {
        DestroyObject (other.gameObject);
    }
}
