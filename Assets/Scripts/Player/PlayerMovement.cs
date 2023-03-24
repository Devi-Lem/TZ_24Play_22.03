using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 10;
    public Rigidbody rb;
    public Animator animator;
    float horizontalInput;
    float horziontalMultiplier = 1.5f;
    int borderLimit = 2;
    private void FixedUpdate()
    {
        float posX = transform.position.x;
        float fixedDeltaTimeSpeed = speed * Time.fixedDeltaTime;
        float sideSpeed = 7f * Time.fixedDeltaTime;

        Vector3 forwardMovment = transform.forward * fixedDeltaTimeSpeed;
        Vector3 deltaPosition = forwardMovment;

        // touch side movements
        if( Input.touchCount > 0 )
        {
            Vector3 touchPosition = Input.GetTouch( 0 ).position;

            // move to the left
            if ( touchPosition.x > Screen.width * 0.5f )
            {
                deltaPosition += transform.right * sideSpeed; 
            }
            // move to the right
            else
            {
                deltaPosition -= transform.right * sideSpeed; 
            }
        }
        // keyboard side movements
        else
        {
            Vector3 horizontalMovement = transform.right * horizontalInput * sideSpeed* horziontalMultiplier;
            deltaPosition += horizontalMovement;
        }

        // if not on the border
        // move to the left
        if(posX > -2 && deltaPosition.x <= 0)
        {
            transform.position += deltaPosition;
            if(transform.position.x < -borderLimit)// if overshot the border return to border limit
                transform.position = new Vector3 (-borderLimit, transform.position.y, transform.position.z);
        }
        // move to the right
        else if(posX < 2 && deltaPosition.x >= 0)
        {
            transform.position += deltaPosition;
            if(transform.position.x  > borderLimit)// if overshot the border return to border limit
                transform.position = new Vector3 (borderLimit, transform.position.y, transform.position.z);
        }
        // move forward
        else
        {
            transform.position += forwardMovment;// move only forward
        }
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

  
}
