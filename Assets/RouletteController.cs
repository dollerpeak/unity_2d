using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotateSpeed = 0;

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
        //Debug.Log("===== FixedUpdate() : Update()���� ��������� ���� ���ų� ���� ȣ��� �� ����, �����Ӵ� �ѹ� ȣ���� ����� �� ����");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("===== Update() : �����Ӵ� �ѹ� ȣ��");
        if (true == Input.GetMouseButtonDown(0))
        {
            this.rotateSpeed = 10;
        }

        transform.Rotate(0, 0, rotateSpeed);
        rotateSpeed *= 0.96f;
        //Debug.Log("rotateSpeed = " + rotateSpeed);
    }

    private void LateUpdate()
    {
        //Debug.Log("===== LateUpdate() : Update()�Ŀ� ����ǰ�, �����Ӵ� �ѹ� ȣ���� ����� �� �ֳ�??");
    }
}
