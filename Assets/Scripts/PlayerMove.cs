using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public float JumpForce = 5f;
    public float turnSpeed = 50f;
    public float rotateSpeed = 20f;

    public Rigidbody rigid;

    private bool isGrounded = true;
    //private void Start()
    
    // Update is called once per frame
    void Update()
    {
        MoveBoris();
        JumpPlayer();
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    void MoveBoris()
    {
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
            transform.Translate (Vector3.forward * speed * Time.deltaTime) ;

        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotateSpeed * Time.deltaTime);

        if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * speed * Time.deltaTime);

    }

    void JumpPlayer()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded = false;
            rigid.AddForce(JumpForce * Vector3.up);
        }
    }
    
   
}
