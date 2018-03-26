using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmotion : MonoBehaviour
{

    public float volume;
    Rigidbody2D rg;
    public float jumpForce = 500;
    public float maxSpeed = 5f;

    float tempTime = 0;

    // Use this for initialization
    void Start()
    {
        rg = this.gameObject.GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {

        volume = NewBehaviourScript.volume; // 0 ~ 1

        if (volume > 0.1)
        {
            MoveForward();
            if (rg.velocity.x > maxSpeed) // limit max force
            {
                rg.velocity = new Vector2(maxSpeed, rg.velocity.y);
            }
        }

        if (volume > 0.4) // based on your laptop microphone setting. have different value.
        {                // better way is to test your microphone first.
            if (Time.time - tempTime > 2) //current time - temptime > 1 sec
            {                             // get the bird back
                Jump();
                tempTime = Time.time;
            }

        }


    }

    void Jump()
    {
        rg.AddForce(Vector2.up * jumpForce * volume); // add F. vector2 x y=1


    }

    void MoveForward()
    {
        rg.AddForce(Vector2.right * 20); // x positive. how far the bird move forwards.
    }

}
