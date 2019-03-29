using System.Collections.Generic;
using UnityEngine;

public class MoveDier : MonoBehaviour
{
    private Rigidbody rb;
    public float schaapSpeed;
    public float rotateMargin;
    private float lastTime;
    private Quaternion targetRotation;
    public float delay;

    public Animator Anim;
    public SheepManagment sheepManagment;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Anim = GetComponent<Animator>();
        lastTime = Random.Range(0f, 1f);
    }



    void FixedUpdate()
    {

        rb.velocity = schaapSpeed * -transform.right;

        if (Time.time >= lastTime + delay)
        {
            targetRotation = Quaternion.Euler(0f, Random.Range(-rotateMargin, rotateMargin), 0f);

            lastTime = Time.time;
        }

        rb.MoveRotation(Quaternion.Lerp(rb.rotation, targetRotation, 0.1f));


    }


    public void IsDead()
    {
        if (this.enabled != false)
        {
            rb.isKinematic = true;
            this.enabled = false;
            sheepManagment.sheepCount += 1;
            Anim.Play("SheepFall");
        }
        

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hek")
        {
            //targetRotation = Quaternion.Euler(0f, 180, 0f);
            //collision.GetContact(0).normal;
            targetRotation = Quaternion.LookRotation(collision.GetContact(0).normal, Vector3.up);

            lastTime = Time.time + 2f;
        }
    }
}
