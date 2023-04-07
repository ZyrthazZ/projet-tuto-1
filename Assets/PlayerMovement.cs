using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    //Reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    
    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Shall we begin ?");
    }

    // When you mess with Physics, it's better to use the 
    //FixesUpdate function rather that the update function
    void FixedUpdate()
    {
        //Add a forward force 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Add a force of 2000 on the z-axis
        
        //Add a specific behaviour when player hits the "move left" input
        if (Input.GetKey("q")) {
            
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0);
            
        }
        
        //Add a specific behaviour when player hits the "move right" input
        if (Input.GetKey("d")) {
            
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0);
            
        }
    }
}
