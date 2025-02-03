using UnityEngine;

public class NumbersAndStringsExample : MonoBehaviour
{
    string total;
    string test = "words! special character$! 2451345";
    int num1;
    float num2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        total = (num1 + num2).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
