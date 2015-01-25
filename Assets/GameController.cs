using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject hazard;
    public Vector3 spawnValues;
    private float time;
    
    void Start ()
    {
        SpawnWaves ();
    }
    
    void SpawnWaves ()
    {
        Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate (hazard, spawnPosition, spawnRotation);
    }

    void FixedUpdate() {
        time += Time.deltaTime;
        if (time > 1.0f) {
            SpawnWaves ();
            time = 0;
        }
    }
}
