using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    public Slider healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = maxHealth;
        currentHealth = maxHealth;
        healthBar.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            IncreaseHealth();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            DecreaseHealth();
        }
    }
    
    public void DecreaseHealth()
    {
        currentHealth -= 10f;

        if(currentHealth < 0)
        {
            currentHealth = 0;
        }

        healthBar.value = currentHealth;
    }

    public void IncreaseHealth()
    {
        currentHealth += 5f;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        healthBar.value = currentHealth;
    }
}
