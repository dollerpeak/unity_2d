using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotateSpeed = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("===== Start()");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("===== Update() : 프레임당 한번 호출");
        if (true == Input.GetMouseButtonDown(0))
        {
            this.rotateSpeed = 10;
        }

        transform.Rotate(0, 0, rotateSpeed);
        rotateSpeed *= 0.96f;
        //Debug.Log("rotateSpeed = " + rotateSpeed);
    }
}
