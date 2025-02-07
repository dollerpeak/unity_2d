using UnityEngine;
using UnityEngine.SceneManagement;

public class SkyController : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rigidbody2D.linearVelocity.y == 0)
        {
            rigidbody2D.AddForce(transform.up * jumpForce);
        }
        if (Input.GetMouseButtonDown(0) && rigidbody2D.linearVelocity.y == 0)
        {
            rigidbody2D.AddForce(transform.up * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
        if (Input.acceleration.x > threshold)
        {
            key = 1;
        }
        if (Input.acceleration.x < -threshold)
        {
            key = -1;
        }

        float speedx = Mathf.Abs(rigidbody2D.linearVelocity.x);
        if (speedx < maxWalkSpeed)
        {
            rigidbody2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (rigidbody2D.linearVelocity.y == 0)
        {
            animator.speed = speedx / 2.0f;
        } else
        {
            animator.speed = 1.0f;
        }
            

        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameSky");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("골~~~~, 유티에프8테스트");
        SceneManager.LoadScene("ClearScene");
    }



}
