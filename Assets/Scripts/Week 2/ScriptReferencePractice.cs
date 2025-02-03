using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public BeegYoshifier yoshiController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yoshiController.scaleIncrease = 5f;
        yoshiController.RotateBeegYoshi();
        yoshiController.RotateBeegYoshi();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
