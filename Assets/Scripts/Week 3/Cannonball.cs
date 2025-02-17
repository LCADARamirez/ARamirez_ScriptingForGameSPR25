using UnityEngine;

public class Cannonball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddRandomForce()
    {
        Vector3 randomDirection = Vector3.zero;

        randomDirection.x = Random.Range(-1f, 1f);
        randomDirection.y = Random.Range(0f, 1f);
        randomDirection.z = Random.Range(-1f, 1f);

        float forceMultiplier = Random.Range(1000, 5000);

        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMultiplier);
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        Debug.Log(otherObject.gameObject.name);

        if(otherObject.gameObject.tag == "Floor")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            otherObject.gameObject.GetComponent<FloorScript>().SayHello();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if(other.gameObject.tag == "UpForce")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1500f);
        }
        else if(other.gameObject.tag == "DownForce")
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 1500f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
