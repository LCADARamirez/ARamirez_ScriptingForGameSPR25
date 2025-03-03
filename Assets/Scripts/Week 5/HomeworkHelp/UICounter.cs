using TMPro;
using UnityEngine;

public class UICounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public int counter = 0;
    public bool allowCounting = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(allowCounting == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CountDown();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                CountUp();
            }
        }
    }

    void CountUp()
    {
        counter++;
        UpdateCounterUI();
    }

    void CountDown()
    {
        //This way will check before you even change the number, if you're allowed to reduce the number.
        //Both of these ways will work as a way to handle checking the counter being out of range.
        if(counter > 0)
        {
            counter--;
        }
        
        //This will check if the number has been changed to an invalid number. If it has, change it to
        //a valid number.
        //Both of these ways will work as a way to handle checking the counter being out of range.
        if(counter < 0)
        {
            counter = 0;
        }

        UpdateCounterUI();
    }

    void UpdateCounterUI()
    {
        counterText.text = counter.ToString();
    }
}
