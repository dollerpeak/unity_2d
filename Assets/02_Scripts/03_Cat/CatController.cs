using UnityEngine;

public class CatController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (true == Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3,0,0);
        }
        else if (true == Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }

        //Debug.Log(Time.deltaTime);

    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }


}
