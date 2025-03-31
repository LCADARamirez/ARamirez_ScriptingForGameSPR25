using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
        {
            attackTimer += Time.deltaTime;

            if(attackTimer > attackSpeed)
            {
                Attack();
                attackTimer = 0;
            }
            
        }
    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);
        //Call an Animation to attack
        //OR
        //Deal Damage to the Player
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Die()
    {
        //Call Death Animation
        //OR
        //Destroy the Object
    }
}
