using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 3f;
    public float defaultTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerCountingDown = defaultTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;

        if(timerCountingDown <= 0)
        {
            Debug.Log("Timer hit 0! Do something!");
            timerCountingDown = defaultTime;
        }
    }
}
