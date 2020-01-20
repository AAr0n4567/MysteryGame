using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody player;
    public Animator anim;
    public float walkSpeed;
    public float runSpeed;
    

    Vector3 input;
    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        input = Vector3.ClampMagnitude(input, 2);

        anim.SetFloat("MoveX", input.x);
        anim.SetFloat("MoveY", input.z);

        player.velocity = input * walkSpeed;

        Debug.Log("player Velocity" + player.velocity);

        // Keep player rotation
        if(input.x != 0)
        {
            transform.forward = player.velocity;
        }
        else
        {
            transform.forward = transform.forward;
        }
        if (input.z != 0)
        {
            transform.forward = player.velocity;
        }
        else
        {
            transform.forward = transform.forward;
        }

    }

}
