using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<Cannonball> cannonballs = new List<Cannonball>();

    public GameObject cannonballPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Finds all objects in the scene that has the Cannonball script on it and turns it into
        //a list to be used by the cannonballs variable, which is a list of Cannonball scripts.
        cannonballs = FindObjectsByType<Cannonball>(FindObjectsSortMode.None).ToList();

        //Finds all GameObjects in the scene with the specified tag. Returns it as an
        //Array of GameObjects that you can convert to a List.
        //GameObject.FindGameObjectsWithTag("Cannonball").ToList();

        GameObject go = Instantiate(cannonballPrefab);
        //You can add an object directly to a list by calling the list variable's name.Add();
        //It must be the same type as the list. If you have a list of GameObjects, make sure
        //you give it a GameObject. In this case, we have a Cannonball script that we want to
        //add to the list of Cannonball scripts.
        cannonballs.Add(go.GetComponent<Cannonball>());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //A foreach loop will go through each object in a List and allow you to do the 
            //same action for every single instance in that list.
            foreach(Cannonball ball in cannonballs)
            {
                ball.AddRandomForce();
            }
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            int randomBall = Random.Range(0, cannonballs.Count);

            //cannonBalls.Count -1 is the actual reference to the last element.
            cannonballs[randomBall].AddRandomForce();
        }
    }
}
