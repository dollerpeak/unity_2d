using UnityEngine;

public class TestController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("왼쪽 클릭을 눌렀습니다.");
        //}
        //if (Input.GetMouseButtonUp(1))
        //{
        //    Debug.Log("마우스 오른쪽 버튼을 클릭했습니다.");
        //}
        //if (Input.GetMouseButtonUp(2))
        //{
        //    Debug.Log("가운데 버튼을 클릭했습니다.");
        //}

        //if(Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("mouse left up");
        //}
        //else if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("mouse left down");
        //}
        //else if (Input.GetMouseButton(0))
        //{
        //    Debug.Log("mouse left down ing");
        //}
        //else
        //{
        //    Debug.Log("mouse left ????????");
        //}

        Debug.Log("11 = " + transform.position);
        transform.Translate(0.1f, 0, 0);
        Debug.Log("22 = " + transform.position);
    }
}
