using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject dog;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            shooting();
        }
    }

    private void shooting()
    {
        Instantiate(dog, transform.position, Quaternion.Euler(0,270,0));
    }
}
