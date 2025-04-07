using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;

    private float attackTimer;

    protected Player player;

    protected NavMeshAgent navAgent;

    [SerializeField]
    protected float aggroRange = 30f;
    
    protected bool hasSeenPlayer = false;

    [SerializeField]
    protected List<Transform> patrolPoints = new List<Transform>();

    protected int patrolPointIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
    }

    protected virtual void Update()
    {
        if(hasSeenPlayer == true)
        {
            if(navAgent.remainingDistance < 0.5f) //Enemy reached the LAST KNOWN location of the player.
            {
                if(Vector3.Distance(this.transform.position, player.transform.position) > aggroRange) //If the player is further than our aggro range...
                {
                    hasSeenPlayer = false; //Enemy no longer sees player, and will be forced to return to patrol paths.
                    
                }
                else //They are NOT out of aggro range
                {
                    if(IsPlayerInLoS() == true) //If the player is within Line of Sight...
                    {
                        navAgent.SetDestination(player.transform.position); //Enemy sees the player and will continue chasing.
                        navAgent.isStopped = false; //Make sure it's allowed to move.
                    }
                    else //If the player is within range, but not within LoS...
                    {
                        hasSeenPlayer = false;
                    }
                }
            }


            //If the player is within attack range
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                if(IsPlayerInLoS() == true)//And if the player is in Line of Sight
                {
                    navAgent.SetDestination(player.transform.position); //Chase the player
                    navAgent.isStopped = false; //Make sure it's allowed to move.
                }
            }
            else //if the player _IS_ within attack range...
            {
                if (IsPlayerInLoS() == true) //and the player is within LoS...
                {
                    navAgent.isStopped = true; //Stop the nav movement
                    this.transform.LookAt(player.transform.position); //Keep looking at the player

                    attackTimer += Time.deltaTime; //Increase the attack timer

                    if (attackTimer > attackSpeed) //Once the attack timer reaches the attack speed
                    {
                        Attack(); //ATTACK!
                        attackTimer = 0; //Reset the timer to 0.
                    }
                }
                else
                {
                    navAgent.isStopped = false;
                }
            }
        }
        else //If the player has NOT been seen...
        {
            if(navAgent.remainingDistance < 0.5f) //If the NavAgent reaches its destination...
            {
                patrolPointIndex++; //Increase the Patrol Point Index so it will move to the next patrol point.

                if(patrolPointIndex >= patrolPoints.Count) //If the patrol point Index is out of range...
                {
                    patrolPointIndex = 0; //Reset it to zero so that it will go back to the first point.
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //SetDestination to determined point.
                navAgent.isStopped = false; //Make sure it's allowed to move.
            }
        }
        
    }

    protected bool IsPlayerInLoS()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position; //Get the direction from this enemy to the player.
        dir.Normalize(); //Normalize the direction so it's within (-1f,1f) for x, y, and z.

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {

            if (hit.collider.tag == "Player")
            {
                return true;
            }

        }

        return false;
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

    public void SeePlayer()
    {
        if(IsPlayerInLoS() == true)
        {
            hasSeenPlayer = true;
        }
    }
}
