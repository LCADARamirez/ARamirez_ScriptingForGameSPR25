using UnityEngine;

public class UpdateInsantiate : MonoBehaviour
{
    public GameObject prefabToSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToSpawn);
        }
    }
}
