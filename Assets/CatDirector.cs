using UnityEngine;
using UnityEngine.UI;

public class CatDirector : MonoBehaviour
{
    GameObject hpGauge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
