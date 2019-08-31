using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public static float speed;
    public int forceConst = 3;
    private bool CanJump;
    private bool IsInAir;

    private Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // turn off cursor and lock in window
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if ((CanJump) && (IsInAir == false))
        {
            CanJump = false;
            rb.AddForce(0, forceConst, 0, ForceMode.Impulse);
        }
    }
    void Update()
    {
        Debug.Log("IsInAir" + IsInAir);
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CanJump = true;
        }

        transform.Translate(straffe, 0, translation); // straffe = x, translate = z (back/forth)

        //if (Input.GetKeyDown("escape"))                        // Turn cursor back on.
          //  Cursor.lockState = CursorLockMode.None;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsInAir = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsInAir = true;
        }
    }
}
