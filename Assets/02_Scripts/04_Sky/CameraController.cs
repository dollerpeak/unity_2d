using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject cat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cat = GameObject.Find("cat");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catPos = cat.transform.position;
        transform.position = new Vector3(transform.position.x, catPos.y, transform.position.z);
    }
}
