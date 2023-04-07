using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Reference to the player
    public Transform player;
    
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Sets the camera position on the player positon and add the offset so the camera 
        //follows the player without FPS view
        
        //transform with non-capital t refers to the Transform object this script
        //is pointing on, here the Main Camera 
        transform.position = player.position + offset;
    }
}
