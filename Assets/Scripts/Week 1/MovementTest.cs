using UnityEngine;

public class MovementTest : MonoBehaviour
{
    //In order to change a transform's position variable, we need to give it another Vector3
    //to move it to because transform.position is a Vector3! And we need to assign variables 
    //to other variables or values of the same datatype!
    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;

    // 2 Slashes and the green text after are called comments. This is not code that runs. It is usually
    // used for notes.
    
    // Start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        //Writes a message to the console of whatever is in the quotation marks (in this case, it's 
        //"Hello World!".
        Debug.Log("Hello World!");

        //in reference to the object THIS script is on, get reference to its TRANSFORM component
        //and get reference to the transform's POSITION, and SET it (=) to Vector3.zero (which means
        //(0,0,0).
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection is currently (1,0,1), and speed is 5. This means this will
        //move (5,0,5) per frame after this calculation of moveDirection * speed. And then, it will
        //be slowed down from per frame to per second by multiplying Time.deltaTime to the end of
        //the equation.
        this.transform.position += moveDirection * speed * Time.deltaTime; //Multiplying by Time.deltaTime means "Per Second" instead of "Per Frame" in Update
        Debug.Log("WHEEEEEEE!");
    }
}
