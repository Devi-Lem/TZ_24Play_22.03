using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();   
    }

    void OnTriggerExit(Collider other)
    {   
        // if player leveas a tile and alive
        if (other.name == "Stickman" && StickmanController.alive)
        {
            groundSpawner.SpawnTile();// spawn new tile
            Destroy(transform.parent.gameObject, 2); // delete old tile on 2 seconds
        }
    }
}
