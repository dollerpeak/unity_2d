using UnityEngine;

public class test : MonoBehaviour
{
    //단축키
    //    코드정렬 : CTRL + K, F
    //    주석처리 : CTRL + K, C / CTRL + K, U

    // 참고 사이트
    // https://github.com/gilbutITbook/080267
    // https://docs.unity3d.com/Manual/index.html
    // https://docs.unity3d.com/kr/2023.2/Manual/UnityManual.html


    private void Awake()
    {
        Debug.Log("===== Awake()");
    }

    private void OnEnable()
    {
        Debug.Log("===== OnEnable()");
    }

    private void Reset()
    {
        Debug.Log("===== Reset()");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("===== Start()");
    }

    private void FixedUpdate()
    {
        Debug.Log("===== FixedUpdate() : Update()전에 실행되지만 보다 많거나 적게 호출될 수 있음, 프레임당 한번 호출을 장담할 수 없음");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("===== Update() : 프레임당 한번 호출");
    }

    private void LateUpdate()
    {
        Debug.Log("===== LateUpdate() : Update()후에 실행되고, 프레임당 한번 호출을 장담할 수 있나??");
    }
}
