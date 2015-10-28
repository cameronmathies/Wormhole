using UnityEngine;
using System.Collections;

public class Telaport : MonoBehaviour {
    public GameObject Port; // Get's the Game Object that has the player tag on it.
    public Transform SpawnPoints; // Get's the transform of the spawn points.
	// Use this for initialization
	
    void OnTriggerEnter(Collider col)
    {
    if(col.tag == "Port") // If Game Object has the tag "Player" then we teleport it.
        {
            Port = col.transform.gameObject;
        }
    }
}
