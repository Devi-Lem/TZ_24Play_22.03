using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    float cameraX, cameraY; 

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
        cameraX = transform.position.x;
        cameraY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        // follow the player
        Vector3 targetPostion = player.position + offset;
        targetPostion.x = cameraX;// freeze x axis
        targetPostion.y = cameraY;// freeze y axis
        transform.position = targetPostion;
    }
}
