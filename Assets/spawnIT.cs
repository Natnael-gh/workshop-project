using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnIT : MonoBehaviour
{
    public GameObject toSpawn;
    public Transform parent;
    public Vector3 newPosition;
    public Quaternion newRotation;
    // Start is called before the first frame update

    public void SpawnIt()
    {
        Instantiate(toSpawn,newPosition,newRotation,parent);




    }
}
