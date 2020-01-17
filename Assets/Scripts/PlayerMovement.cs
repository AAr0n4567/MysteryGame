using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody player;
    public Animator anim;
    public float walkSpeed;
    public float runSpeed;

    Vector2 input;
    private void Start()
    {
        player = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 2);

        anim.SetFloat("MoveX", input.x);
        anim.SetFloat("MoveY", input.y);
    }
}
