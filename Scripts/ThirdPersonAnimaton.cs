using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonAnimaton : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    private float maxSpeed = 5f;


    void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();

        
    }

    void Update()
    {
        animator.SetFloat("Blend", rb.velocity.magnitude / maxSpeed);
    }
}
