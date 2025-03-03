using UnityEngine;

public class ExampleBooScript : MonoBehaviour
{
    public Rigidbody rbody;
    public Vector3 moveDir;
    public float speed = 5f;
    public float timer = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        //Use this for moving rigidbodies around that will care about colliders!
        rbody.AddForce(moveDir * speed * Time.deltaTime);

        //Here, do a timer that at the end of the timer, it will reset the timer and then call ChangeDirection()
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            ChangeDirection();
            timer = 5f;
        }
        //Don't do this for rigidbodies moving around!
        //this.transform.position += moveDir * speed * Time.deltaTime;
    }

    void ChangeDirection()
    {
        moveDir = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, -1f));
    }
}
