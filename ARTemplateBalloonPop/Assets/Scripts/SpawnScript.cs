using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // we wait
    // spawn balloon model from spawn point

    // Coroutine 
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.0f, 1.0f));
        int randomBalloonIndex = Random.Range(0, balloons.Length);

        int randomSpawnPointsIndex = Random.Range(0, spawnpoints.Length);

        Instantiate(balloons[randomBalloonIndex], spawnpoints[randomSpawnPointsIndex].position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
}
