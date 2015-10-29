using UnityEngine;
using System.Collections;

public class TelaportTake2 : MonoBehaviour
{
    public GameObject Target_1;
    public GameObject Target_2;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("warking?");
        switch (other.name)
        {
            case "Teleporter_1":
                gameObject.transform.position = Target_1.transform.position;
                break;

            case "Teleporter_2":
                gameObject.transform.position = Target_2.transform.position;
                break;
        }

    }

}
