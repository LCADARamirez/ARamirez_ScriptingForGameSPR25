using UnityEngine;

public class DatatypePractice : MonoBehaviour
{
    //An integer (referred to as int) is a whole number, meaning no decimals!
    int santaClaus;

    //Floats are floating point numbers (decimals!) If you need a number with a decimal, you must use
    //a float!
    float total;
    //telling a variable it is public will mean you can change it in the inspector for whatever
    //GameObject this is attached to.
    public float mario;
    public float yoshi = 4.8f;

    //Characters are only allowed to be 1 letter or character on a keyboard. Make sure to use
    //an apostrophe to surround the character you want it to represent!
    char bee = 'B';

    //A string is technically a string of characters, which could mean a word or an entire paragraph!
    //Make sure to use quotation marks to say what the string is.
    string fullSentence;
    string intro = "Hello World!";
    string outro = "Cya Later!";

    public string chestName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;

        //Math is possible using +, -, *, or / with numbers of the same type. Try to keep
        //integers doing math with integers, and floats doing math with floats!
        santaClaus = (santaClaus + 5) * 2 / (3 - 7);

        Debug.Log(santaClaus);

        Debug.Log(yoshi);

        //Subtracts 2 from the current value of yoshi.
        yoshi = yoshi - 2;

        //Subtracts 2 from the current value of yoshi (written differently!)
        yoshi -= 2;

        Debug.Log("Yoshi's value is " + yoshi);

        Debug.Log(bee + intro);

        //You can mix and match literal numbers in math with variables. Try to keep most things
        //as variable representations of numbers!
        total = mario + 7 + yoshi;

        Debug.Log(total);

        //Even strings can be added together into a larger string. You may need to add a space between
        //the strings though, otherwise, they might be squished together.
        fullSentence = intro + " " + outro;

        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
