using TMPro;
using UnityEngine;

public class GameUiScript : MonoBehaviour
{

    public GameObject zebrasLeftText;
    TextMeshProUGUI zebrasLeftTMP;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zebrasLeftTMP = zebrasLeftText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetZebrasLeft(int num)
    {
        zebrasLeftTMP.text = $"Zebror kvar: {num}";
    }
}
