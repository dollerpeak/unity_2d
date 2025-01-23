using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;

        //distance.GetComponent<TMP_Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        //distance.GetComponent<TextMeshProUGUI>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        if (length >= 0)
        {
            distance.GetComponent<TextMeshProUGUI>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }
        else
        {
            distance.GetComponent<TextMeshProUGUI>().text = "Game Over";
        }

    }
}
