using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnScript : MonoBehaviour
{
    public Transform limit1, limit2;

    public GameObject[] basuras;

    public float timespawn;
    public float repeatspawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBasura", timespawn, repeatspawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBasura()
    {
        Vector3 spawnposition = new Vector3(Random.Range(limit2.position.x, limit1.position.x), transform.position.y, Random.Range(limit2.position.x, limit1.position.x));

        GameObject basura = Instantiate(basuras[Random.Range(0, basuras.Length)], spawnposition, gameObject.transform.rotation);
    }
}
