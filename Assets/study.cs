using UnityEngine;

public class test : MonoBehaviour
{
    //����Ű
    //    �ڵ����� : CTRL + K, F
    //    �ּ�ó�� : CTRL + K, C / CTRL + K, U

    // ���� ����Ʈ
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
        Debug.Log("===== FixedUpdate() : Update()���� ��������� ���� ���ų� ���� ȣ��� �� ����, �����Ӵ� �ѹ� ȣ���� ����� �� ����");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("===== Update() : �����Ӵ� �ѹ� ȣ��");
    }

    private void LateUpdate()
    {
        Debug.Log("===== LateUpdate() : Update()�Ŀ� ����ǰ�, �����Ӵ� �ѹ� ȣ���� ����� �� �ֳ�??");
    }
}
