using UnityEngine;
using System.Collections;

public class InstaMove : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        transform.position = transform.position + new Vector3(0, 0, 0.7f);
    }
}
