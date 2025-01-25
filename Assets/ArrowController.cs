using UnityEngine;

public class ArrowController : MonoBehaviour
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
        transform.Translate(0, -0.1f, 0);

        if(transform.position.y < -5.0f)
        {
            Destroy(this.gameObject);
        }

        Vector2 arrowPos = transform.position;
        Vector2 catPos = cat.transform.position;
        Vector2 dir = arrowPos-catPos;

        float crashDir = dir.magnitude;
        float crashArrow = 0.5f;
        float crashCat = 1.0f;

        if (crashDir < crashArrow + crashCat)
        {
            Destroy (this.gameObject);
        }



    }
}
