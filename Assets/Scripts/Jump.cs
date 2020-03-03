using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rigidbody;
    public bool ballIsOnGround = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && ballIsOnGround)
        {
            rigidbody.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
            ballIsOnGround = false;
        }
    }

    private void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            ballIsOnGround = true;
        }
    }
}
