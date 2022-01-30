using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Camera normalCamera, mapCamera;
    public PlayerController controller;
    public float runSpeed = 40f;

    private float m_HorizontalMove = 0f;
    private bool m_Jump = false;
	
    // Update is called once per frame
    private void Update () {



        if (Input.GetButtonDown("Submit"))
        {
            normalCamera.gameObject.SetActive(false);
            mapCamera.gameObject.SetActive(true);
        }

        if (Input.GetButtonUp("Submit"))
        {
            normalCamera.gameObject.SetActive(true);
            mapCamera.gameObject.SetActive(false);
        }
        m_HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            m_Jump = true;
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
        
    }

    private void FixedUpdate ()
    {
        if (Input.GetButton("Submit")) return;
        controller.Move(m_HorizontalMove * Time.fixedDeltaTime, m_Jump);
        m_Jump = false;
    }
}