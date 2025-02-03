using UnityEngine;

public class BeegYoshifier : MonoBehaviour
{
    public GameObject beegYoshi;
    public float scaleIncrease = .5f;
    public GameObject youDiedScreen;

    public Vector3 rotationAmount;

    public Transform teleportTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        beegYoshi.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if(beegYoshi.transform.localScale.x > 42)
        {
            youDiedScreen.SetActive(true);
        }
    }

    public void ResetBeegYoshi()
    {
        beegYoshi.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }

    public void RotateBeegYoshi()
    {
        //The following line will rotate beegYoshi by -90 degrees in the z direction by
        //creating a new Vector3 variable to be used once at runtime.
        //beegYoshi.transform.Rotate(new Vector3(0f, 0f, -90f));

        //Alternatively, you can create a varaible of type Vector3 to pass into the rotate
        //function, like in the following line. This makes it so you can change the
        //functionality in the inspector without having to change any code.
        beegYoshi.transform.Rotate(rotationAmount);
    }

    public void TeleportBeegYoshi()
    {
        beegYoshi.transform.position = teleportTransform.position;
    }
}
