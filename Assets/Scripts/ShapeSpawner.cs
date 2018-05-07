using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{


    public GameObject shapePrefab;
    public Transform[] spawnPoints;
    public float minDelay;
    public float maxDelay;
    float deleteDelay = 2f;
  
    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawnShapes());
    }

    IEnumerator spawnShapes()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            // Spawn Shapes
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            GameObject clone;
            // Instanstiate then delete after a one second
            clone = Instantiate(shapePrefab, spawnPoint.position, spawnPoint.rotation);
            // Check if the object was destroyed
            if (clone != null)
            {
                
                yield return new WaitForSeconds(deleteDelay);
                // Check again if object was destroyed after a delay, and if not destroyed delete after delay
                if (clone != null)
                {
                    Destroy(clone);
                  //  Debug.Log("clone was deleted");
                }
            }
        }

    }
   
}