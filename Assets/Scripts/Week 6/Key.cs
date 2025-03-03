using UnityEngine;

//This enum gives us a custom Datatype that has specific values that it can be (KeyColor.Red/Blue/Yellow)
public enum KeyColor
{
    Red,
    Blue,
    Yellow
}

public class Key : MonoBehaviour
{
    //We create a variable of the type of enum we created so we can keep track of which color this key is.
    public KeyColor color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Depending on the color of this key, at Start, we will color each key properly so visually we can
        //see the color of the key we're picking up.
        if(color == KeyColor.Red)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if(color == KeyColor.Blue)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if(color == KeyColor.Yellow)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
