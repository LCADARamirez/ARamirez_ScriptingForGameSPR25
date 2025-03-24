using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public int numEnemies;

    public GameObject enemyPrefab;

    public CounterText counterScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numEnemies = Random.Range(5, 25);

        for(int i = 0; i < numEnemies; i++)
        {
            Instantiate(enemyPrefab);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if time runs out...
        CheckPlayerAnswer();
    }

    void CheckPlayerAnswer()
    {
        if(numEnemies == counterScript.counter)
        {
            Debug.Log("You win!");
        }
        else
        {
            Debug.Log("You lose!");
        }
    }
}
