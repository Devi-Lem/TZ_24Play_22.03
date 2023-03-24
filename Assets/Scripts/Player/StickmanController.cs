using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanController : MonoBehaviour
{
    Animator animator;
    public GameObject ragdoll;
    public DeathUI deathUI;
    public PlayerMovement playerMovement;
    public CameraFollow cameraFollow;
    public static bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        alive = true;
    }

    public void Jump()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);// move player up
        animator.SetTrigger("Jump");// play jumping animation
    }

    void OnTriggerEnter(Collider other)
    {
        // if player hits the wall
        if (other.tag == "Wall")
        {
            Dead();// player is dead
        }
    }

    public void Dead()
    {
        Rigidbody parentRb = transform.parent.GetComponent<Rigidbody>();// get player rigidbody
        parentRb.useGravity = false;//turn of player gravity
        parentRb.constraints = RigidbodyConstraints.None;// all object to rotate and move
        animator.enabled = false;// turn off player animator
        playerMovement.enabled = false;// turn off player movement
        cameraFollow.enabled = false;// turn off camera following script
        ragdoll.SetActive(true);// activate players ragdoll 
        deathUI.Trigger();// open failure UI screen
        alive = false;// set player state as dead
    }
}
