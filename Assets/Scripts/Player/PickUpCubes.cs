using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCubes : MonoBehaviour
{
    public StickmanController stickmanController;
    void OnTriggerEnter(Collider other)
    {
        // if collided with pickupable cube
        if(other.tag == "Pickup")
        {
            stickmanController.Jump();// play jumping
            other.tag = "Picked";// change cube state to picked
            Destroy(other.gameObject);// destroy cube on tile
            Vector3 lastChildPos = transform.parent.GetChild(transform.parent.childCount-1).position;// get position of last cube oin stack 
            Vector3 childVector = new Vector3(lastChildPos.x, lastChildPos.y + 1, lastChildPos.z);// create position for new cube on stack
            Instantiate(transform.parent.GetChild(transform.parent.childCount-1), childVector, Quaternion.identity).SetParent(transform.parent);// create new cube and add it to the stack
        }
    }
}
