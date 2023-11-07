using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float XBound = -30f;
    [SerializeField] private float YBound = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= XBound)
        {
            Destroy(gameObject);
        }

        else if(transform.position.y <= YBound && gameObject.tag != "Dog")
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
