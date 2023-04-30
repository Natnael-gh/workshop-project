using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public float rate = 1f;
    // Start is called before the first frame update
    
    public void SpawnIt()
    {
              Instantiate(toSpawn, transform.position + Random.insideUnitSphere, Quaternion.identity);
   


       
    }
}
