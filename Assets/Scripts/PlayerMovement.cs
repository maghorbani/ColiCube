using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float forwardForce = 202f;
    [SerializeField] private float sidewayForce = 20f;
    [SerializeField] private float jumpPower = 10f;

    private bool canJump = true;

    public void enableJump()
    {
        canJump = true;
    }

    void FixedUpdate()
    {
        m_rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
        // Input.Get
        // float horiz = Input.GetAxis("Horizontal");
        // m_rigidbody.AddForce(Time.deltaTime * horiz * sidewayForce, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("a") && canJump)
        {

            m_rigidbody.AddForce(-Time.deltaTime * sidewayForce, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d") && canJump)
        {

            m_rigidbody.AddForce(Time.deltaTime * sidewayForce, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && canJump)
        {
            m_rigidbody.AddForce(0, jumpPower, 0, ForceMode.Impulse);
            canJump = false;
        }

        if (m_rigidbody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
