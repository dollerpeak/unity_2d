using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true == Input.GetMouseButtonDown(0))
        {
            speed = 0.2f;
        }
        transform.Translate(speed,0,0);
        speed *= 0.98f;
    }
}
