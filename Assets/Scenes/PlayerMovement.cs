using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    //Variables
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // This is used to mess with physics in Unity whereas the Update method is
    // used for the once-per-frame way of updating things.
	void FixedUpdate ()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //User input
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Check for falling cube (end of game)
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
