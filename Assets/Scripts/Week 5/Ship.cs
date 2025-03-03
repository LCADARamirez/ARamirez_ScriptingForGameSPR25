using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.InstanceID).ToList();

        cannons[0].FireCannon(); //Fires the First cannon in the list
        cannons[1].FireCannon(); //Fires the second cannon in the list
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }
        
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            FireAllPowerfulCannons();
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            FireAllWeakCannons();
        }
    }

    void FireAllCannons()
    {
        //This fires all cannons using a foreach loop.
        foreach (Cannon c in cannons)
        {
            c.FireCannon();
        }

        //This fires all cannons using a for loop.
        /*for (int i = 0; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();
        }*/
    }

    void FireEvenCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            //If it's odd, don't fire.
            //If it's even, fire!
            //The mod operator (%) does division between the two numbers and returns
            //the remainder. If the remainder of something % 2 is 0, it is even!
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }
        }
    }

    void FireAllPowerfulCannons()
    {
        foreach(Cannon c in cannons)
        {
            if(c.forcePower >= 4500)
            {
                c.FireCannon();
            }
        }
    }

    void FireAllWeakCannons()
    {
        for(int i = 0; i < cannons.Count; i++)
        {
            if (cannons[i].forcePower < 4500)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
