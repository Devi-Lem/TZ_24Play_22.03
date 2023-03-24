using UnityEngine;

public class PickupCube : MonoBehaviour
{
    public Rigidbody rb;
    public CameraShake cameraSahke;
    void OnTriggerEnter(Collider other)
    {  
        // if cube hit the wall
        if(other.tag == "Wall")
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;// allow cube to move
            transform.parent = null;// remove cube from stack
            Destroy(gameObject, 2);// destroy cube in 2 seconds
            StartCoroutine(cameraSahke.Shake(.05f, 1f));// shake the camera
            Handheld.Vibrate();// vibrate the phone
        }
    }
}
