using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public List<GameObject> groundTile;
    Vector3 nextSpawnPoint;
    public void SpawnTile()
    {
        int randomInt = Random.Range(0,5);// choose random tile to spawn from 5 presets
        GameObject temp = Instantiate(groundTile[randomInt], nextSpawnPoint, Quaternion.identity);// spawn tile at the end of previous
        nextSpawnPoint = temp.transform.GetChild(0).GetChild(1).transform.position;// set new point to spawn a tile
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnTile();
        }
    }

 
}
