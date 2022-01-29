using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public PlayerController controller;

    public float runSpeed = 40f;

    private float m_HorizontalMove = 0f;
    private bool m_Jump = false;
	
    // Update is called once per frame
    private void Update () {

        m_HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            m_Jump = true;
        }
    }

    private void FixedUpdate ()
    {
        // Move our character
        controller.Move(m_HorizontalMove * Time.fixedDeltaTime, m_Jump);
        m_Jump = false;
    }
}