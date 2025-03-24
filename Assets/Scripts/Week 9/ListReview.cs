using System.Collections.Generic;
using UnityEngine;

public class ListReview : MonoBehaviour
{

    public List<GameObject> cubes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubes[0].SetActive(false); //First cube in the list.

        cubes[cubes.Count - 1].SetActive(false); //Last cube in the list.

        foreach(GameObject c in cubes) //This iterates through all objects in the list called "cubes".
                                        //when in this foreach loop, the individual element will be
                                        //referenced as 'c'.
        {
            Debug.Log(c.name); //Displays the name of each cube in the list.
        }

        for(int i = 0; i < cubes.Count; i++)
        {
            Debug.Log(cubes[i].name);

            if(i % 2 == 0) //if I divided by 2 has a remainder of 0... this means it's even.
            {
                Debug.Log(cubes[i].name + " is an even element!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
