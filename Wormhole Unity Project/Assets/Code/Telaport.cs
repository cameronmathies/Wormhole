using UnityEngine;
using System.Collections;

public class Telaport : MonoBehaviour {
    public GameObject Player; // Get's the Game Object that has the player tag on it.
    public Transform SpawnPoints; // Get's the transform of the spawn points.
	// Use this for initialization
	
    void OnTriggerEnter(Collider col)
    {
    if(col.tag == "Player") // If Game Object has the tag "Player" then we teleport it.
        {
            Player = col.transform.parent.gameObject.transform.parent.gameObject;
            Player.transform.position = SpawnPoints.transform.position;
            Player.transform.rotation = SpawnPoints.transform.rotation;
        }
    }
}
