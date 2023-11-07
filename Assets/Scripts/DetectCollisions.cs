using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != gameObject.tag)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
