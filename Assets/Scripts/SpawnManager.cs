using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spawns;

    [SerializeField] private float maxX;
    [SerializeField] private float minX;
    [SerializeField] private float valueY;
    [SerializeField] private float Interval;
    [SerializeField] private float startDelay;

    void Start()
    {
        InvokeRepeating("SpawnBall", startDelay, Interval);
    }

    private void SpawnBall()
    {
        int ball = Random.Range(0,spawns.Length);
        Instantiate(spawns[ball], randompos(), Quaternion.Euler(90,0,0)) ;
    }

    private Vector3 randompos()
    {
        return new Vector3 (Random.Range(minX, maxX), valueY, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
