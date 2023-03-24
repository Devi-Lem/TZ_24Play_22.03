using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public StickmanController stickmanController;
    // Update is called once per frame
    void Update()
    {
        // if no cubes left in stack
        if(transform.childCount == 0)
        {
            stickmanController.Dead();// player is dead
        }
    }
}
