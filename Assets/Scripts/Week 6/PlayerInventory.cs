using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasYellowKey = false;

    public GameObject playerCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //Are we looking at the door?
            RaycastHit hitObject; //This variable contains the data of what will be
            //hit by the Raycast we're able to make.

            //Do a raycast from an origin point going out in a direction. If it hits something, that data
            //will be stored in the hitObject variable above. It will also only go out 10f units from the origin point.
            if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                //Check if the object the Raycast hit is tagged as a door.
                if(hitObject.collider.gameObject.tag == "Door")
                {
                    //Get reference to the door script since we need to refer to it many times.
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();
                    //Check each door color and if we have the proper key for that door. If it is proper, open!
                    if(lookedAtDoor.doorColor == KeyColor.Red && hasRedKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if(lookedAtDoor.doorColor == KeyColor.Blue && hasBlueKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if(lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                }
            }


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the object we hit the trigger for is tagged as a key...
        if (other.gameObject.tag == "Key")
        {
            //Get reference to the key's color since we refer to it multiple times and don't want to
            //GetComponent too many times at once.
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;

            //Check if the key's color is Red/Blue/Yellow, and if it is, set the bool keeping track
            //of the player having those keys to true.
            if (pickedUpKeyColor == KeyColor.Red)
            {
                hasRedKey = true;
            }
            else if (pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
            }
            else if(pickedUpKeyColor == KeyColor.Yellow)
            {
                hasYellowKey = true;
            }
            //Then destroy the object since we don't want it anymore!
            Destroy(other.gameObject);
        }
    }
}
