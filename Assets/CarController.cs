using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true == Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (true == Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            speed = swipeLength / 4000f;

            GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed,0,0);
        speed *= 0.98f;
    }
}
