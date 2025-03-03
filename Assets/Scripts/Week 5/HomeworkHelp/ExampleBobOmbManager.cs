using System.Collections.Generic;
using UnityEngine;

public class ExampleBobOmbManager : MonoBehaviour
{
    public List<ExampleBobOmb> bobombs = new List<ExampleBobOmb>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int bobombToExplode = Random.Range(0, bobombs.Count);
        bobombs[bobombToExplode].Explode();
        bobombs.RemoveAt(bobombToExplode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
